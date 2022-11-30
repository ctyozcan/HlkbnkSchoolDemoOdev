namespace SchoolDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fillClassDepartments();
            fillInstructorBranches();
            
            for (int i = 65; i <= 90; i++)
            {
                comboBoxSube.Items.Add((char)i);
            }
        }
        

        private void fillClassDepartments()
        {
            var names = Enum.GetNames<Departments>();
            names.ToList().ForEach(n => comboBoxBolum.Items.Add(n));
        }
        private void fillInstructorBranches()
        {
            var names = Enum.GetNames<Branches>();
            names.ToList().ForEach(n => comboBoxEgitmenBransi.Items.Add(n));
        }

        private void fillstudents()
        {
            //Student studentsinf= new Student();
            //studentsinf.Name = textBoxOgrenciAdi.Text;
            //studentsinf.LastName= textBoxOgrenciSoyadi.Text;
            //studentsinf.Address = textBoxOgrenciAdresi.Text;
            //string ogradsoyad = studentsinf.Name + ' ' + studentsinf.LastName;

            ClassRoom ogr = new ClassRoom();
            ogr.AddStudent(new Student { Name=textBoxOgrenciAdi.Text, LastName=textBoxOgrenciSoyadi.Text,Address=textBoxOgrenciAdresi.Text});

            
            var ogrenci = ogr.ListStudent();
            foreach (var student in ogrenci)
            {
                listBoxOgrenciler.Items.Add(student.Name+' '+student.LastName);
                listViewSiniflar.SelectedItems[0].SubItems[1].Text=Convert.ToString(++ogrsayi);
            }
            

        }
        private void fillInstructor()
        {
            ClassRoom hoca = new ClassRoom();
            hoca.AddInstructor(new Instructor { Name = textBoxEgitmenAdi.Text, LastName = textBoxEgitmenSoyadi.Text, Department = comboBoxEgitmenBransi.Text });


            var teacher = hoca.ListInstructor();
            foreach (var a in teacher)
            {
                listViewSiniflar.SelectedItems[0].SubItems[2].Text=(a.Name + ' ' + a.LastName);
            }


        }
        public int ogrsayi,sinifsayi = 0;
        public bool sinifacildi=false;
        
        private void fillClassRoom()
        {
            ClassRoom sinif = new ClassRoom();
            var sinif2 = new ClassRoom { ClassNo = int.Parse(textBoxSinifNo.Text), Letter = Convert.ToString(comboBoxSube.SelectedItem), Department = Convert.ToString(comboBoxBolum.SelectedItem) };
            sinif.GetClassRooms().Add(sinif2);
            sinifsayi++;
            
            var ders = sinif.ListClassRoom();
            foreach (var a in ders)
            {
                var t =a.ClassNo.ToString() + '-' + a.Department + '-' + a.Letter;
                string[] row= {t,Convert.ToString(ogrsayi),"Atanmadý." };
                var satir= new ListViewItem(row);
                listViewSiniflar.Items.Add(satir);
                groupBox2.Enabled= true;
                sinifacildi= true;
            }
        }

        private void buttonOgrenciEkle_Click(object sender, EventArgs e)
        {
            if (textBoxOgrenciAdi.Text != "" && textBoxOgrenciSoyadi.Text != "" && textBoxOgrenciAdresi.Text != "")
            {
                if(listViewSiniflar.SelectedItems.Count==0)
                {
                    MessageBox.Show("Öðrenci eklemek için seçim yapýnýz.");
                }
                else if(sinifacildi==false)
                {
                    MessageBox.Show("Henüz açýlmýþ bir sýnýf mevcut deðil.");
                }
                else
                fillstudents();
            }
            else
            {
                MessageBox.Show("Öðrenci Bilgileri Boþ Geçilemez.");
            }
            
        }

        private void buttonEgitmenAta_Click(object sender, EventArgs e)
        {

            if(textBoxEgitmenAdi.Text!="" || textBoxEgitmenSoyadi.Text!="" || comboBoxEgitmenBransi.Text!="")
            {
                fillInstructor();
            }
            else
            {
                MessageBox.Show("Eðitmen Bilgileri Boþ Geçilemez.");
            }
             
        }

        private void buttonSinifOlustur_Click(object sender, EventArgs e)
        {
            ogrsayi = 0;
            fillClassRoom();
            listViewSiniflar.Show();
        }

        
    }
}