using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using DevExpress.Data;

namespace WindowsFormsApplication1
{
    
    public partial class Dbmodhist : Form
    {
        public Dbmodhist()
        {
            InitializeComponent();
        }

        private void Dbmodhist_Load(object sender, EventArgs e)
        {
            Adapter adapter = new Adapter();
             

            //EMPCD콤보박스하고 데이터 베이스하고 연결
            string ComboQuery = "SELECT EMPCD, EMPNM FROM TB_S_EMP";
            DataSet dataset = adapter.CellReference(ComboQuery);
            ComboBox_EMPCD.DataSource = dataset.Tables[0];
            ComboBox_EMPCD.DisplayMember = "EMPNM";
            ComboBox_EMPCD.ValueMember = "EMPCD";

            //CUSTCD콤보박스하고 데이터 베이스하고 연결
            string ComboQuery2 = "SELECT CUSTCD, CUSTNM FROM TB_CUST";
            dataset = adapter.CellReference(ComboQuery2);
            ComboBox_CUSTCD.DataSource = dataset.Tables[0];
            ComboBox_CUSTCD.DisplayMember = "CUSTNM";
            ComboBox_CUSTCD.ValueMember = "CUSTCD";

            //콤보박스 임의의 값 설정
            ComboBox_Contects_Reset();
        }

        //패널1(위)조회 버튼 클릭
        /// <summary>
        /// 조회 버튼 클릭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnReference_Click(object sender, EventArgs e)
        {
            //초기화/추가 버튼 활성화, 조회버튼 비활성화
            BtnReset_Panel1.Enabled = true;
            BtnCreate_Panel1.Enabled = true;
            BtnReference.Enabled = false;

            //데이터베이스 연결한 것을 가져온다.
            Adapter adapter = new Adapter();

            //이너 조인한것을 패널1(위)에 표시
            string Query = "SELECT TB_PJT.PJTCD, TB_PJT.PJTNM, TB_PJT.EMPCD, TB_S_EMP.EMPNM, TB_PJT.CUSTCD, TB_CUST.CUSTNM " +
                "FROM TB_PJT [tb_pjt] INNER JOIN TB_S_EMP [tb_s_emp] ON tb_pjt.EMPCD = tb_s_emp.EMPCD " +
                "INNER JOIN TB_CUST[tb_cust] ON tb_pjt.CUSTCD = tb_cust.CUSTCD";

            //패널1(위) 표 나타내기
            DataSet dataset = adapter.CellReference(Query);
            Gridcontrol1.DataSource = dataset.Tables[0];
            gridView1.BestFitColumns();

            //패널1(위) 모든 선택해제
            gridView1.FocusInvalidRow();

            //콤보박스 임의의 값 설정
            ComboBox_Contects_Reset();
        }

        //추가 버튼 클릭
        /// <summary>
        /// 추가 버튼 클릭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCreate_Click(object sender, EventArgs e)
        {
            Adapter adapter = new Adapter();            

            if (MaskedTextBox_PJTCD.Text.Length < 8)
            {
                MessageBox.Show("공백은 적을 수 없습니다. 숫자 8자리 입력하세요.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MaskedTextBox_PJTCD.Text = "";
            }

            string Query = "SELECT PJTCD FROM TB_PJT;";
            DataSet pjtdataset = adapter.CellReference(Query);

            //기본키 중복된거 있는지 확인
            for(int i = 0; i < pjtdataset.Tables[0].Rows.Count; i++)
            {
                if (MaskedTextBox_PJTCD.Text == pjtdataset.Tables[0].Rows[i][0].ToString())
                {
                    MessageBox.Show("PJTCD는 중복 될 수 없습니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MaskedTextBox_PJTCD.Text = "";
                }
            }
            
            //비어있을 때
            if (MaskedTextBox_PJTCD.Text == "" | TextBox_PJTNM.Text == "")
            {
                MessageBox.Show("모든 칸을 제대로 입력해주세요.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //데이터베이스에 쿼리 추가
                string insertQuery = "INSERT INTO TB_PJT(PJTCD, PJTNM, EMPCD, CUSTCD) VALUES('"
                    + MaskedTextBox_PJTCD.Text + "', '" + TextBox_PJTNM.Text + "', '" + ComboBox_EMPCD.SelectedValue.ToString() + "', '" + 
                    ComboBox_CUSTCD.SelectedValue.ToString() + "');";

                //텍스트를 이용해서 추가한다               
                adapter.Create(insertQuery);

                //이너 조인한것을 패널1(위)에 표시
                string joinQuery = "SELECT TB_PJT.PJTCD, TB_PJT.PJTNM, TB_PJT.EMPCD, TB_S_EMP.EMPNM, TB_PJT.CUSTCD, TB_CUST.CUSTNM " +
                    "FROM TB_PJT [tb_pjt] INNER JOIN TB_S_EMP [tb_s_emp] ON tb_pjt.EMPCD = tb_s_emp.EMPCD " +
                    "INNER JOIN TB_CUST[tb_cust] ON tb_pjt.CUSTCD = tb_cust.CUSTCD";
                DataSet dataset = adapter.CellReference(joinQuery);
                Gridcontrol1.DataSource = dataset.Tables[0];
                gridView1.BestFitColumns();

                //패널1(위) 입력 박스 전부 초기화
                Panel1_Text_Contects_Reset();

                //패널1(위) 모든 선택해제
                gridView1.FocusInvalidRow();       
            }          
        }

        //수정 버튼 클릭
        /// <summary>
        /// 수정 버튼 클릭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>comp
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            //비어있을 때
            if (MaskedTextBox_PJTCD.Text == "" | TextBox_PJTNM.Text == "")
            {
                MessageBox.Show("모든 칸 입력해주세요.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //데이터베이스에 쿼리 수정
                string updateQuery = "UPDATE TB_PJT SET PJTCD = " + MaskedTextBox_PJTCD.Text + ", PJTNM = '" + TextBox_PJTNM.Text +
                    "', EMPCD = '" + ComboBox_EMPCD.SelectedValue.ToString() + "', CUSTCD = '" + ComboBox_CUSTCD.SelectedValue.ToString()
                     + "' WHERE PJTCD = " + MaskedTextBox_PJTCD.Text + ";";

                //텍스트를 이용해서 수정한다.
                Adapter adapter = new Adapter();
                adapter.Update(updateQuery);

                //이너 조인한것을 패널1(위)에 표시
                string Query = "SELECT TB_PJT.PJTCD, TB_PJT.PJTNM, TB_PJT.EMPCD, TB_S_EMP.EMPNM, TB_PJT.CUSTCD, TB_CUST.CUSTNM " +
                    "FROM TB_PJT [tb_pjt] INNER JOIN TB_S_EMP [tb_s_emp] ON tb_pjt.EMPCD = tb_s_emp.EMPCD " +
                    "INNER JOIN TB_CUST[tb_cust] ON tb_pjt.CUSTCD = tb_cust.CUSTCD";
                DataSet dataset = adapter.CellReference(Query);
                Gridcontrol1.DataSource = dataset.Tables[0];
                gridView1.BestFitColumns();

                //패널1(위) 입력 박스 전부 초기화
                Panel1_Text_Contects_Reset();

                //패널2(아래) 텍스트 박스 초기화
                Panel2_Text_Contects_Reset_FK("");

                //패널2(아래) 표 비우기
                Gridcontrol2.DataSource = null;
                gridView2.BestFitColumns();

                //패널1(위): 추가 버튼 활성화, 수정/삭제 버튼 비활성화
                Panel1_Createtrue_UpdateDeletefalse();

                //패널2(아래) 모든 버튼 비활성화
                Panel2_Btn_Allfalse();

                //텍스트박스 활성화
                MaskedTextBox_PJTCD.ReadOnly = false;

                //패널1(위) 모든 선택해제
                gridView1.FocusInvalidRow();
            }           
        }

        //삭제 버튼 클릭
        /// <summary>
        /// 삭제 버튼 클릭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            Adapter adapter = new Adapter();            

            string Query = "SELECT TB_PJT.PJTCD, TB_PJT.PJTNM, TB_PJT.EMPCD, TB_S_EMP.EMPNM, TB_PJT.CUSTCD, TB_CUST.CUSTNM " +
                        "FROM TB_PJT [tb_pjt] INNER JOIN TB_S_EMP [tb_s_emp] ON tb_pjt.EMPCD = tb_s_emp.EMPCD " +
                        "INNER JOIN TB_CUST[tb_cust] ON tb_pjt.CUSTCD = tb_cust.CUSTCD";

            //삭제여부를 묻기위한 메세지 창
            DialogResult dialogResult = MessageBox.Show("선택한 것들을 삭제하겠습니까? \n안에 있는 디테일도 삭제 해야 삭제가 가능합니다.", "삭제", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                DialogResult dialogResult2 = MessageBox.Show("안에 있는 디테일도 삭제하겠습니까?", "삭제", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult2 == DialogResult.Yes)
                {
                    //체크박스 선택 되있는것을 찾아서 삭제
                    foreach (int id in gridView1.GetSelectedRows())
                    {
                        //데이터베이스에 쿼리 삭제
                        string deleteQuery2 = "DELETE FROM TB_CONINFO WHERE PJTCD = " + gridView1.GetRowCellValue(id, "PJTCD").ToString() + ";";

                        //텍스트를 이용해서 추가한다.   
                        adapter.Delete(deleteQuery2);

                        //데이터베이스에 쿼리 삭제
                        string deleteQuery = "DELETE FROM TB_PJT WHERE PJTCD = " + gridView1.GetRowCellValue(id, "PJTCD").ToString() + ";";

                        //텍스트를 이용해서 추가한다.
                        adapter.Delete(deleteQuery);
                    }

                    MessageBox.Show("삭제 성공", "삭제", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("안에 있는 디테일도 삭제 해야 삭제가 가능합니다.", "삭제 조건", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }    

            //이너 조인한것을 패널1(위)에 표시
            DataSet dataset = adapter.CellReference(Query);
            Gridcontrol1.DataSource = dataset.Tables[0];
            gridView1.BestFitColumns();

            //패널2(아래) 비우기
            Gridcontrol2.DataSource = null;
            gridView2.BestFitColumns();

            //패널1(위) 모든 선택해제
            gridView1.FocusInvalidRow();

            //패널1(위) 입력 박스 전부 초기화
            Panel1_Text_Contects_Reset();

            //패널2(아래) 텍스트 박스 초기화
            Panel2_Text_Contects_Reset_FK("");

            //패널1(위): 추가 버튼 활성화, 수정/삭제 버튼 비활성화
            Panel1_Createtrue_UpdateDeletefalse();

            //텍스트박스 활성화
            MaskedTextBox_PJTCD.ReadOnly = false;
        }

        //패널2(아래)추가 버튼 클릭
        /// <summary>
        /// 패널2(아래)추가 버튼 클릭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCreate_Panel2_Click(object sender, EventArgs e)
        {
            //데이터베이스에 쿼리 추가
            string insertQuery = "INSERT INTO TB_CONINFO(PJTCD, CONCAT, CONCOMNM, CONWINID, CONWINPASS, " + 
                "CONIP, CONSUBNET, CONGATE, CONPORT) VALUES('" +
                TextBox_PJTCD.Text + "', '" + TextBox_CONCAT.Text + "', '" + TextBox_CONCOMNM.Text + "', '" + TextBox_CONWINID.Text + "', '" +
                TextBox_CONWINPASS.Text + "', '" + TextBox_CONIP.Text + "', '" + TextBox_CONSUBNET.Text + "', '" + TextBox_CONGATE.Text + "', '" + TextBox_CONPORT.Text + "');";

            //쿼리문으로 기본키하고 같은것을 셀렉트
            string drQuery = "select PJTCD, CONSEQ, CONCAT, CONCOMNM, CONWINID, CONWINPASS, " +
                "CONIP, CONSUBNET, CONGATE, CONPORT from TB_CONINFO " +
                "where PJTCD = " + TextBox_PJTCD.Text;

            //패널2(아래)에 넣음
            Adapter adapter = new Adapter();
            adapter.Create(insertQuery);
            DataSet dataset = adapter.CellReference(drQuery);
            Gridcontrol2.DataSource = dataset.Tables[0];
            gridView2.BestFitColumns();

            //패널2(아래) 기본키를 제외한 텍스트 박스 초기화
            Panel2_Text_Contects_Reset();

            //패널2(아래) 초기화 버튼 비활성화
            BtnReset_Panel2.Enabled = false;

            //패널2(아래) 선택 해제
            gridView2.FocusInvalidRow();
        }

        //패널2(아래)수정 버튼 클릭
        /// <summary>
        /// 패널2(아래)수정 버튼 클릭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnUpdate_Panel2_Click(object sender, EventArgs e)
        {
            //데이터베이스에 쿼리 수정
            string updateQuery = "UPDATE TB_CONINFO SET PJTCD = '" + TextBox_PJTCD.Text +
                "', CONCAT = '" + TextBox_CONCAT.Text + "', CONCOMNM = '" + TextBox_CONCOMNM.Text + "', CONWINID = '" + TextBox_CONWINID.Text +
                "', CONWINPASS = '" + TextBox_CONWINPASS.Text + "', CONIP = '" + TextBox_CONIP.Text + "', CONSUBNET = '" + TextBox_CONSUBNET.Text +
                "', CONGATE = '" + TextBox_CONGATE.Text + "', CONPORT = '" + TextBox_CONPORT.Text +
                "' WHERE PJTCD = " + TextBox_PJTCD.Text + "AND CONSEQ = " + TextBox_CONSEQ.Text + ";";

            //텍스트를 이용해서 수정한다.
            Adapter adapter = new Adapter();
            adapter.Update(updateQuery);

            //쿼리문으로 기본키하고 같은것을 셀렉트
            string drQuery = "select PJTCD, CONSEQ, CONCAT, CONCOMNM, CONWINID, CONWINPASS, " +
                "CONIP, CONSUBNET, CONGATE, CONPORT from TB_CONINFO " +
                "where PJTCD = " + MaskedTextBox_PJTCD.Text;

            //패널2(아래)에 넣음
            DataSet dataset = adapter.CellReference(drQuery);
            Gridcontrol2.DataSource = dataset.Tables[0];
            gridView2.BestFitColumns();

            //패널2(아래) 기본키를 제외한 텍스트 박스 초기화
            Panel2_Text_Contects_Reset();

            //패널2(아래) 추가 버튼 활성화, 초기화/수정/삭제 버튼 비활성화
            Panel2_Createtrue_Remainsfalse();

            //패널2(아래) 선택 해제
            gridView2.FocusInvalidRow();
        }
        
        //패널2(아래)삭제 버튼 클릭
        /// <summary>
        /// 패널2(아래)삭제 버튼 클릭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnDelete_Panel2_Click(object sender, EventArgs e)
        {
            Adapter adapter = new Adapter();

            //삭제여부를 묻기위한 메세지 창
            DialogResult dialogResult = MessageBox.Show("삭제하겠습니까?", "삭제", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {
                //삭제하기 위해서 리스트에 선택된 행 아이디 넣기
                foreach (int id in gridView2.GetSelectedRows())
                {
                    //데이터베이스에 쿼리 삭제
                    string deleteQuery = "DELETE FROM TB_CONINFO WHERE PJTCD = " + gridView2.GetRowCellValue(id, "PJTCD").ToString() +
                        " AND CONSEQ = " + gridView2.GetRowCellValue(id, "CONSEQ").ToString() + ";";

                    //텍스트를 이용해서 삭제한다.                   
                    adapter.Delete(deleteQuery);
                }
            }

            //쿼리문으로 기본키하고 같은것을 셀렉트
            string drQuery = "select PJTCD, CONSEQ, CONCAT, CONCOMNM, CONWINID, CONWINPASS, " +
                "CONIP, CONSUBNET, CONGATE, CONPORT from TB_CONINFO " +
                "where PJTCD = " + MaskedTextBox_PJTCD.Text;

            //패널2(아래)에 넣음
            DataSet drdataset = adapter.CellReference(drQuery);
            Gridcontrol2.DataSource = drdataset.Tables[0];
            gridView2.BestFitColumns();

            //패널2(아래) 기본키를 제외한 텍스트 박스 초기화
            Panel2_Text_Contects_Reset();

            //패널2(아래) 추가 버튼 활성화, 초기화/수정/삭제 버튼 비활성화
            Panel2_Createtrue_Remainsfalse();

            //패널2(아래) 선택 해제
            gridView2.FocusInvalidRow();
        }

        //초기화 버튼
        /// <summary>
        /// 초기화 버튼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnReset_Click(object sender, EventArgs e)
        {
            //패널1(위) 입력 박스 전부 초기화
            Panel1_Text_Contects_Reset();

            //패널2(아래) 텍스트 박스 비우기
            Panel2_Text_Contects_Reset_FK("");

            Adapter adapter = new Adapter();
            //패널1(위) 표 비우기
            Gridcontrol1.DataSource = null;
            gridView1.BestFitColumns();

            //패널2(아래) 표 비우기
            Gridcontrol2.DataSource = null;
            gridView2.BestFitColumns();

            //쓰는걸 막아뒀던 텍스트 박스를 다시 풀기
            MaskedTextBox_PJTCD.ReadOnly = false;

            //조회를 제외한 버튼 모두 막기
            BtnReference.Enabled = true;
            BtnReset_Panel1.Enabled = false;
            BtnCreate_Panel1.Enabled = false;
            BtnUpdate_Panel1.Enabled = false;
            BtnDelete_Panel1.Enabled = false;
            Panel2_Btn_Allfalse();
        }

        //패널2(아래) 초기화 버튼
        private void BtnReset_Panel2_Click(object sender, EventArgs e)
        {
            //패널2(아래) 선택 해제
            gridView2.FocusInvalidRow();

            //패널2(아래) 기본키를 제외한 텍스트 박스 초기화
            Panel2_Text_Contects_Reset();

            //패널2(아래) 추가 버튼 활성화, 초기화/수정/삭제 버튼 비활성화
            Panel2_Createtrue_Remainsfalse();
        }

        //마스크텍스트박스에 숫자가 아닌 것을 입력 할 때 또는 8자리 넘길려고 할 때
        private void MaskedTextBox_PJTCD_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            MessageBox.Show("숫자 8자리만 입력", "경고", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        /// <summary>
        /// 선택상태가 바뀔때마다 이벤트 발생
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridView1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Adapter adapter = new Adapter();            

            //패널1(위) 기본키 텍스트 박스 편집 못하게 하기
            MaskedTextBox_PJTCD.ReadOnly = true;

            //패널1(위): 추가/조회 버튼 비활성화, 수정 버튼 활성화
            BtnReference.Enabled = false;
            BtnCreate_Panel1.Enabled = false;
            BtnDelete_Panel1.Enabled = true;

            //패널2(아래) 추가 버튼 활성화, 초기화/수정/삭제 버튼 비활성화
            Panel2_Createtrue_Remainsfalse();

            //패널2(아래) 선택 해제
            gridView2.FocusInvalidRow();

            if (gridView1.GetSelectedRows().Count() == 0)
            {
                //패널2(아래) 표 비우기
                Gridcontrol2.DataSource = null;
                gridView2.BestFitColumns();

                //마스크텍스트박스 활성화
                MaskedTextBox_PJTCD.ReadOnly = false;

                //패널1(위) 입력 박스 전부 초기화
                Panel1_Text_Contects_Reset();

                //패널2(아래) 텍스트 박스 전부 초기화
                Panel2_Text_Contects_Reset_FK("");

                //패널1(위) 추가 활성화, 삭제/수정 비활성화
                Panel1_Createtrue_UpdateDeletefalse();

                //패널2(아래) 버튼 전부 비활성화
                Panel2_Btn_Allfalse();
            }
            else
            {
                //체크박스로 선택된 것이 1개면 수정버튼 활성화, 입력칸에 체크박스로 선택된 것 넣기
                if (gridView1.GetSelectedRows().Count() == 1)
                {
                    //수정버튼 활성화
                    BtnUpdate_Panel1.Enabled = true;

                    //체크박스로 선택된 행을 리스트로 만든다음
                    int id = gridView1.GetSelectedRows()[0];

                    //쿼리문으로 기본키하고 같은것을 셀렉트
                    string drQuery = "select PJTCD, CONSEQ, CONCAT, CONCOMNM, CONWINID, CONWINPASS, " +
                        "CONIP, CONSUBNET, CONGATE, CONPORT from TB_CONINFO " +
                        "where PJTCD = " + gridView1.GetRowCellValue(id, "PJTCD").ToString();

                    //패널2(아래)에 넣음                    
                    DataSet dataset = adapter.CellReference(drQuery);
                    Gridcontrol2.DataSource = dataset.Tables[0];
                    gridView2.BestFitColumns();

                    //패널1(위) 텍스트 박스에 정보들 전부 넣음
                    MaskedTextBox_PJTCD.Text = gridView1.GetRowCellValue(id, "PJTCD").ToString();
                    TextBox_PJTNM.Text = gridView1.GetRowCellValue(id, "PJTNM").ToString();
                    ComboBox_EMPCD.Text = gridView1.GetRowCellValue(id, "EMPNM").ToString();
                    ComboBox_CUSTCD.Text = gridView1.GetRowCellValue(id, "CUSTNM").ToString();

                    //패널2(아래) 텍스트 박스에 기본키 넣고 나머지는 초기화
                    Panel2_Text_Contects_Reset_FK(MaskedTextBox_PJTCD.Text);
                }
                else
                {
                    //패널2(아래) 표 비우기
                    Gridcontrol2.DataSource = null;
                    gridView2.BestFitColumns();

                    //패널1(위) 입력 박스 전부 초기화
                    MaskedTextBox_PJTCD.Text = "";
                    TextBox_PJTNM.Text = "";
                    ComboBox_EMPCD.Text = "";
                    ComboBox_CUSTCD.Text = "";

                    //패널2(아래) 텍스트 박스 전부 초기화
                    Panel2_Text_Contects_Reset_FK("");

                    //패널1(위) 삭제 활성화, 추가/수정 비활성화
                    BtnCreate_Panel1.Enabled = false;
                    BtnUpdate_Panel1.Enabled = false;
                    BtnDelete_Panel1.Enabled = true;

                    //패널2(아래) 버튼 전부 비활성화
                    Panel2_Btn_Allfalse();

                    //패널1(위) 입력 박스 전부 초기화
                    Panel1_Text_Contects_Reset();
                }              
            }
        }

        /// <summary>
        /// 선택상태가 바뀔때마다 이벤트 발생
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridView2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //패널2(아래) 추가버튼 빼고 활성화
            BtnReset_Panel2.Enabled = true;
            BtnCreate_Panel2.Enabled = false;
            BtnDelete_Panel2.Enabled = true;

            if (gridView2.GetSelectedRows().Count() == 0)
            {
                //패널2(아래) 텍스트 박스 초기화
                Panel2_Text_Contects_Reset_FK(MaskedTextBox_PJTCD.Text);

                //초기화/추가 활성화, 삭제/수정 비활성화
                BtnReset_Panel2.Enabled = true;
                BtnCreate_Panel2.Enabled = true;
                BtnUpdate_Panel2.Enabled = false;
                BtnDelete_Panel2.Enabled = false;
            }
            else
            {
                //체크박스로 선택된 것이 1개면 수정버튼 활성화, 입력칸에 체크박스로 선택된 것 넣기
                if (gridView2.GetSelectedRows().Count() == 1)
                {
                    //수정버튼 활성화
                    BtnUpdate_Panel2.Enabled = true;

                    //체크박스로 선택된 행을 리스트로 만든다음
                    int id = gridView2.GetSelectedRows()[0];

                    //패널2(아래) 텍스트 박스에 정보들 전부 넣음
                    TextBox_PJTCD.Text = gridView2.GetFocusedRowCellValue("PJTCD").ToString();
                    TextBox_CONSEQ.Text = gridView2.GetRowCellValue(id, "CONSEQ").ToString();
                    TextBox_CONCAT.Text = gridView2.GetRowCellValue(id, "CONCAT").ToString();
                    TextBox_CONCOMNM.Text = gridView2.GetRowCellValue(id, "CONCOMNM").ToString();
                    TextBox_CONWINID.Text = gridView2.GetRowCellValue(id, "CONWINID").ToString();
                    TextBox_CONWINPASS.Text = gridView2.GetRowCellValue(id, "CONWINPASS").ToString();
                    TextBox_CONIP.Text = gridView2.GetRowCellValue(id, "CONIP").ToString();
                    TextBox_CONSUBNET.Text = gridView2.GetRowCellValue(id, "CONSUBNET").ToString();
                    TextBox_CONGATE.Text = gridView2.GetRowCellValue(id, "CONGATE").ToString();
                    TextBox_CONPORT.Text = gridView2.GetRowCellValue(id, "CONPORT").ToString();
                }
                else
                {
                    //패널2(아래) 기본키를 제외한 텍스트 박스 초기화
                    Panel2_Text_Contects_Reset();

                    //초기화/삭제 활성화, 추가/수정 비활성화
                    BtnReset_Panel2.Enabled = true;
                    BtnCreate_Panel2.Enabled = false;
                    BtnUpdate_Panel2.Enabled = false;
                    BtnDelete_Panel2.Enabled = true;
                }          
            }     
        }

        /// <summary>
        /// 마스크텍스트박스 클릭으로 인한 공백 방지
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MaskedTextBox_PJTCD_Click(object sender, EventArgs e)
        {
            //뒤 공백 비우기
            String s = MaskedTextBox_PJTCD.Text.Trim();

            //입력된 곳으로 이동
            if (MaskedTextBox_PJTCD.SelectionStart > s.Length)
            {
                MaskedTextBox_PJTCD.SelectionStart = s.Length;
            }
        }

        /// <summary>
        /// 방향키로 인한 공백 방지
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MaskedTextBox_PJTCD_KeyPress(object sender, KeyPressEventArgs e)
        {
            //뒤 공백 비우기
            String s = MaskedTextBox_PJTCD.Text.Trim();

            //입력된 곳으로 이동
            if (MaskedTextBox_PJTCD.SelectionStart > s.Length)
            {
                MaskedTextBox_PJTCD.SelectionStart = s.Length;
            }
        }

        private void Panel1_Text_Contects_Reset()
        {
            //패널1(위) 텍스트 박스 비우기
            MaskedTextBox_PJTCD.Text = "";
            TextBox_PJTNM.Text = "";

            //콤보박스 임의의 값 설정
            ComboBox_EMPCD.Text = "오현진";
            ComboBox_CUSTCD.Text = "test";
        }

        private void ComboBox_Contects_Reset()
        {
            //콤보박스 임의의 값 설정
            ComboBox_EMPCD.Text = "오현진";
            ComboBox_CUSTCD.Text = "test";
        }

        /// <summary>
        /// 패널2(아래) 텍스트 박스 기본키 제외하고 비우기
        /// </summary>
        private void Panel2_Text_Contects_Reset()
        {
            TextBox_CONSEQ.Text = "";
            TextBox_CONCAT.Text = "";
            TextBox_CONCOMNM.Text = "";
            TextBox_CONWINID.Text = "";
            TextBox_CONWINPASS.Text = "";
            TextBox_CONIP.Text = "";
            TextBox_CONSUBNET.Text = "";
            TextBox_CONGATE.Text = "";
            TextBox_CONPORT.Text = "";
        }

        /// <summary>
        /// 패널2(아래) 기본키 넣고, 나머지는 비우기
        /// </summary>
        /// <param name="fk"></param>
        private void Panel2_Text_Contects_Reset_FK(string fk)
        {
            TextBox_PJTCD.Text = fk;
            TextBox_CONSEQ.Text = "";
            TextBox_CONCAT.Text = "";
            TextBox_CONCOMNM.Text = "";
            TextBox_CONWINID.Text = "";
            TextBox_CONWINPASS.Text = "";
            TextBox_CONIP.Text = "";
            TextBox_CONSUBNET.Text = "";
            TextBox_CONGATE.Text = "";
            TextBox_CONPORT.Text = "";
        }

        /// <summary>
        /// 패널1(위) 추가 버튼 활성화, 수정/삭제 비활성화
        /// </summary>
        private void Panel1_Createtrue_UpdateDeletefalse()
        {
            BtnCreate_Panel1.Enabled = true;
            BtnUpdate_Panel1.Enabled = false;
            BtnDelete_Panel1.Enabled = false;
        }

        /// <summary>
        /// 패널2(아래) 모든 버튼 비활성화
        /// </summary>
        private void Panel2_Btn_Allfalse()
        {
            BtnReset_Panel2.Enabled = false;
            BtnCreate_Panel2.Enabled = false;
            BtnUpdate_Panel2.Enabled = false;
            BtnDelete_Panel2.Enabled = false;
        }

        /// <summary>
        /// 패널2(아래) 추가버튼 활성화 나머지 버튼들은 비활성화
        /// </summary>
        private void Panel2_Createtrue_Remainsfalse()
        {
            BtnCreate_Panel2.Enabled = true;
            BtnReset_Panel2.Enabled = false;
            BtnUpdate_Panel2.Enabled = false;
            BtnDelete_Panel2.Enabled = false;
        }

        class Adapter
        {
            //DB 연결
            static string conString = "data Source = .; user id = saa; password = 1234; initial catalog = NEMO;";
            static DataSet ds;
            static public SqlConnection con = new SqlConnection(conString);

            //값을 추가/삭제/수정해서 DB가 바뀐 것을 앱에 전달해주기위해서
            /// <summary>
            /// DB -> 앱 전달
            /// </summary>
            /// <param name="drQuery"></param>
            /// <returns></returns>
            public DataSet CellReference(string Query)
            {
                ds = new DataSet();

                con.Open();
                SqlDataAdapter celladapter = new SqlDataAdapter(Query, con);
                celladapter.Fill(ds);
                con.Close();
                return ds;
            }

            //추가 기능
            /// <summary>
            /// 추가 기능
            /// </summary>
            /// <param name="pjtcd"></param>
            /// <param name="pjtnm"></param>
            /// <param name="empcd"></param>
            /// <param name="custcd"></param>
            /// <param name="insertQuery"></param>
            /// <returns></returns>
            public void Create(string createQuery)
            {
                con.Open();
                //DB에 추가한다.
                SqlCommand com = new SqlCommand(createQuery, con);

                //예외 처리
                try
                {
                    // 만약에 내가처리한 Mysql에 정상적으로 들어갔다면 메세지를 보여주라는 뜻이다
                    if (com.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("추가 성공", "추가", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("추가 실패", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                con.Close();
            }

            //수정 기능
            /// <summary>
            /// 수정 기능
            /// </summary>
            /// <param name="updateQuery"></param>
            public void Update(string updateQuery)
            {
                con.Open();
                //DB에 수정한다.
                SqlCommand com = new SqlCommand(updateQuery, con);

                //예외 처리
                try
                {
                    // 만약에 내가처리한 Mysql에 정상적으로 들어갔다면 메세지를 보여주라는 뜻이다
                    if (com.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("수정 성공", "수정", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("수정 실패", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                con.Close();
            }

            //삭제 기능
            /// <summary>
            /// 삭제 기능
            /// </summary>
            /// <param name="deleteQuery"></param>
            public void Delete(string deleteQuery)
            {
                con.Open();
                //DB에 삭제한다.
                SqlCommand com = new SqlCommand(deleteQuery, con);

                //예외 처리
                try
                {
                    // 1개이상 삭제 성공
                    if (com.ExecuteNonQuery() >= 1)
                    {

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                con.Close();
            }
        }

        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {

        }
    }
}
