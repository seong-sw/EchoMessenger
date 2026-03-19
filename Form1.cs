namespace EchoMessenger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void send_Message() // 함수로 선언해서 코드 축약
        {
            if (!string.IsNullOrWhiteSpace(txtMessage.Text)) // txtMessage.Text가 null이 아니고 공백이 아닌 경우에만 실행
            {
                if (txtMessage.Text.Length > 50)
                {
                    MessageBox.Show("메시지는 50자 이하로 입력해주세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMessage.Clear(); // txtMessage.Text 값을 초기화
                }
                else
                {
                    // 변수 선언 및 txtMessage.Text 값을 할당하여 msg_send 변수에 저장
                    string msg_send;
                    msg_send = txtMessage.Text.Trim(); // Trim() 메소드를 사용하여 txtMessage.Text의 앞뒤 공백 제거

                    // txtList에 msg_send 변수의 값을 추가
                    txtList.Items.Add($"{DateTime.Now.ToString("[HH:mm:ss]")} {msg_send}"); // 현재 시간을 메시지 앞에 붙여 출력

                    // lblCount의 Text 값을 txtList.Items.Count로 설정하여 메시지 개수 표시
                    lblCount.Text = $"현재 대화 : {txtList.Items.Count}개";

                    // txtMessage.Text 값을 초기화
                    txtMessage.Clear();

                    // txtMessage에 포커스 설정
                    this.ActiveControl = txtMessage;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // txtMessage에 포커스 설정
            this.ActiveControl = txtMessage;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            send_Message();
        }

        private void txtMessage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                send_Message();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtList.SelectedItems == null || txtList.Items.Count == 0) // txtList에서 선택된 항목이 없는 경우
            {
                MessageBox.Show("삭제할 메시지를 선택해주세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // txtList에서 선택된 항목을 제거
                txtList.Items.Remove(txtList.SelectedItems[0]);

                // lblCount의 Text 값을 txtList.Items.Count로 설정하여 메시지 개수 표시
                lblCount.Text = $"현재 대화 : {txtList.Items.Count}개";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtList.Items.Clear(); // txtList의 모든 항목 제거

            // lblCount의 Text 값을 txtList.Items.Count로 설정하여 메시지 개수 표시
            lblCount.Text = $"현재 대화 : {txtList.Items.Count}개";
        }
    }
}