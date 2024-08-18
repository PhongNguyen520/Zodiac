using Services;

namespace ZodiacGUI
{

    // dấu : chính là kế thừa, tương đương extends trong Java
    //class Form là class có sẵn trong SDK  tương đương page HTML
    //ta chỉ việc kế thừa và độ lại class này: độ đặc tính của class này: cao, rộng, màu sắc, bắt các hành động của user trên màn hình...
    //ta có thể thêm bớt các component/ control/ thành phần UI bày lên form 
    //y chang add <tag> và trang html
    //Form này cũng HTML: phần render ra màn hình xem cho đẹp, khi run cũng như design
    //chuyển từ mode design/render sang mode source code html -> F12
    //(browser) với VS dùng phím F7 , chuyển từ code sang design dùng shift + F7
    // 1 FORM ~ 1 CLASS ~ 1 cửa sổ ~ 1 màn hình dc render
    //Sẽ dính dáng đến 3 tập tin trên HDD/SSD trên Project
    //.CS  : CHỨA CODE MÌNH SẼ GÕ LIÊN QUAN ĐẾN XỬ LÍ NHỮNG GÌ DIỄN RA TRÊN MÀN HÌNH, PHẢN ỨNG LẠI THAO TÁC CHUỘT, BÀN PHÍM CỦA USER
    //.DESIGN.CS  : CHỨA CODE CỦA PHẦN DESIGN MÀN HÌNH - TỰ ĐỘNG VISUAL STUDIO LÀM GIÚP KHI TA THÊM BỚT "tag" TRÊN MÀN HÌNH
    // TA KO ĐỤNG VÀO FILE NÀY, coi chừng hỏng phần design cửa sổ
    //.RESX : .....

    //CÓ 2 VIỆC CẦN LÀM VỚI CLASS FORM KẾ THỪA NÀY:
    //1. ADD CÁC COMPONENT/CONTROL/THÀNH PHẦN/"TAG" LÊN TRÊN MÀN HÌNH/ CỬA SỔ -DESIGN UI

    //2. VIẾT CODE XỬ LÍ CÁC SỰ KIỆN, HÀNH ĐỘNG DIỄN RA TRÊN CỬA SỔ 
    // USER CLICK NÚT NHẤN, USER INPUT VÀO Ô NHẬP...

    //1. DESIGN: ADD THÊM CÁC "TAG"
    //          THIẾT LẬP CÁC PROPERTY {GET, SET} CHO CÁC "TAG"
    //          THIẾT LẬP = CÁCH DÙNG CỬA SỔ CẤU HÌNH
    //          CHỌN TAG CẦN THIẾT LẬP THAY ĐỔI, NHẤN F4

    //VÀO CODE DESIGN  .DESIGNER.CS SỬA TRỰC TIẾP PHẦN AUTO GENERATED CỦA VISUAL STUDIO - KHUYÊN KO NÊN DÙNG NẾU KO HIỂU 
    public partial class ZodiacMain : Form
    {
        public ZodiacMain()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show("Do you really want to exit?", "Quit?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (answer == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            //Lấy ngày sinh, tháng sinh ra để xử lí
            string day = txtBirthDay.Text;
            string month = txtBirthMonth.Text;
            //Gọi service giúp tính giùm cung hoàng đạo
            string zodiacSignEn = ZodiacCalculator.GetZodiacEnglish(int.Parse(month), int.Parse(day));
            string zodiacSignVn = ZodiacCalculator.GetZodiacVietnamese(zodiacSignEn);

            //show result
            lblResult.Text = "Your zodiac is: "+zodiacSignVn + "|"+ zodiacSignEn;
            //MessageBox.Show("Your birthday: " + day + "/" + month, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //MessageBox.Show("Hello GUI", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Hand);
        }

    }
}
