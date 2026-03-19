namespace EchoMessenger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            // 변수 선언 및 txtMessage.Text 값을 할당하여 msg_send 변수에 저장
            string msg_send;
            msg_send = txtMessage.Text;

            // txtList에 msg_send 변수의 값을 추가
            txtList.Items.Add(msg_send);

            // txtMessage.Text 값을 초기화
            txtMessage.Clear();
        }
    }
}