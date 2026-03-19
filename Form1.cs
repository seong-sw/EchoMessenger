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
                // 변수 선언 및 txtMessage.Text 값을 할당하여 msg_send 변수에 저장
                string msg_send;
                msg_send = txtMessage.Text;

                // txtList에 msg_send 변수의 값을 추가
                txtList.Items.Add(msg_send);

                // txtMessage.Text 값을 초기화
                txtMessage.Clear();

                // txtMessage에 포커스 설정
                this.ActiveControl = txtMessage;
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
    }
}