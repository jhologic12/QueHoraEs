namespace QueHoraEs
{
    public partial class Form1 : Form
    {
        private TimeZonaService _timeZoneService;
        public Form1()
        {
            InitializeComponent();
            _timeZoneService = new TimeZonaService();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbltimer1.Text = DateTime.Now.ToString("HH:mm");
            lblSegundo1.Text = DateTime.Now.ToString("ss");
            lblFecha1.Text = DateTime.Now.ToString("MMM dd yyyy");
            lblDia1.Text = DateTime.Now.ToString("dddd");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Start();
            timer3.Start();
            timer4.Start();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            var localDate = _timeZoneService.ObtenerFechadelTimeZone("China Standard Time");


            lblTimer3.Text = localDate.ToString("HH:mm");
            lblSegundo3.Text = localDate.ToString("ss");
            lblFecha3.Text = localDate.ToString("MMM dd yyyy");
            lblDia3.Text = localDate.ToString("dddd");
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            var localDate = _timeZoneService.ObtenerFechadelTimeZone("Tokyo Standard Time");


            lblTimer4.Text = localDate.ToString("HH:mm");
            lblSegundo4.Text = localDate.ToString("ss");
            lblFecha4.Text = localDate.ToString("MMM dd yyyy");
            lblDia4.Text = localDate.ToString("dddd");




        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            var localDate = _timeZoneService.ObtenerFechadelTimeZone("Eastern Standard Time");
            
           
            lbltimer2.Text = localDate.ToString("HH:mm");
            lblsegundo2.Text = localDate.ToString("ss");
            lblFecha2.Text = localDate.ToString("MMM dd yyyy");
            lblDia2.Text = localDate.ToString("dddd");
        }
    }
}