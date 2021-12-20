using QuanLiRapChieuPhim.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiRapChieuPhim.AddForms
{
    public partial class FormAddInfoStaff : Form
    {
        public FormAddInfoStaff()
        {
            InitializeComponent();
        }
        string CreateID()
        {
            string idc = "";
            string query = "select * from InfoStaff";
            DataTable table = DataProvider.Instance.ExecuteQuery(query);

            for (int i = 0; i <= table.Rows.Count + 1; i++)
            {
                if (i < 10) idc = "NV0" + i;
                else idc = "NV" + i;
                foreach (DataRow rows in table.Rows)
                {
                    if (rows["ID"].ToString() != idc)
                    {
                        if (rows["ID"].ToString() == "AD00") continue;
                        else break;
                    }
                }
            }
            return idc;
        }
        public FormAddInfoStaff(DataGridView Grid)
        {
            InitializeComponent();
            InfoStaffGridView = Grid;
            AddButton.BringToFront();
            IDTextbox.Text = CreateID();
            IDTextbox.ReadOnly = true;
        }
        byte[] pic;

        // image -> byte, insert image into database
        public void imageToByteArray(string path, string id)
        {
            string query = "update InfoStaff set Avatar = (select * from openrowset(bulk N'" + path + "', single_blob) as img) where ID = '" + id + "'";
            DataProvider.Instance.ExecuteQuery(query);
        }
        // byte[] -> image, get image from database
        public static Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }
        public FormAddInfoStaff(string ID, string FullName, string DoB, string Sex, string Address, string PhoneNum, string Email, string IDPersonal)
        {
            InitializeComponent();

            IDTextbox.Text = ID;
            FullNameTextbox.Text = FullName;
            DoBTextbox.Text = DoB;
            AddressTextbox.Text = Address;
            PhoneTextbox.Text = PhoneNum;
            EmailTextbox.Text = Email;
            IDPersonalTextbox.Text = IDPersonal;
            string query = "SELECT Avatar FROM dbo.InfoStaff where id ='" + ID + "'";
            DataTable table = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow rows in table.Rows)
            {
                pic = (byte[])rows["Avatar"];
            }
            pictureBox1.BackgroundImage = byteArrayToImage(pic); 
            IDTextbox.ForeColor = Color.White;
            FullNameTextbox.ForeColor = Color.White;
            DoBTextbox.ForeColor = Color.White;
            AddressTextbox.ForeColor = Color.White;
            PhoneTextbox.ForeColor = Color.White;
            EmailTextbox.ForeColor = Color.White;
            IDPersonalTextbox.ForeColor = Color.White;

            if (Sex == "Nam")
            {
                MaleCheckbox.Checked = true;
            }
            else if((Sex == "Nữ"))
            {
                FemaleCheckbox.Checked = true;
            }
            IDTextbox.ReadOnly = true;
            EditButton.BringToFront();
        }

        string Sex;
        DataGridView InfoStaffGridView = new DataGridView();

        void LoadInfoStaff()
        {
            string query = "SELECT * FROM InfoStaff";
            InfoStaffGridView.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }

        private void IDTextbox_Enter(object sender, EventArgs e)
        {
            if (IDTextbox.Text == "ID")
            {
                IDTextbox.Text = "";
                IDTextbox.ForeColor = Color.White;
            }
        }

        private void FullNameTextbox_Enter(object sender, EventArgs e)
        {
            if (FullNameTextbox.Text == "Full Name")
            {
                FullNameTextbox.Text = "";
                FullNameTextbox.ForeColor = Color.White;
            }
        }

        private void DoBTextbox_Enter(object sender, EventArgs e)
        {
            if (DoBTextbox.Text == "Birthday")
            {
                DoBTextbox.Text = "";
                DoBTextbox.ForeColor = Color.White;
            }
        }

        private void AddressTextbox_Enter(object sender, EventArgs e)
        {
            if (AddressTextbox.Text == "Address")
            {
                AddressTextbox.Text = "";
                AddressTextbox.ForeColor = Color.White;
            }
        }

        private void PhoneTextbox_Enter(object sender, EventArgs e)
        {
            if (PhoneTextbox.Text == "Phone Number")
            {
                PhoneTextbox.Text = "";
                PhoneTextbox.ForeColor = Color.White;
            }
        }

        private void EmailTextbox_Enter(object sender, EventArgs e)
        {
            if (EmailTextbox.Text == "Email")
            {
                EmailTextbox.Text = "";
                EmailTextbox.ForeColor = Color.White;
            }
        }

        private void IDPersonalTextbox_Enter(object sender, EventArgs e)
        {
            if (IDPersonalTextbox.Text == "ID Personal")
            {
                IDPersonalTextbox.Text = "";
                IDPersonalTextbox.ForeColor = Color.White;
            }
        }

        private void IDTextbox_Leave(object sender, EventArgs e)
        {
            if (IDTextbox.Text == "")
            {
                IDTextbox.Text = "ID";
                IDTextbox.ForeColor = Color.FromArgb(190, 62, 66);
            }
        }

        private void FullNameTextbox_Leave(object sender, EventArgs e)
        {
            if (FullNameTextbox.Text == "")
            {
                FullNameTextbox.Text = "Full Name";
                FullNameTextbox.ForeColor = Color.FromArgb(190, 62, 66);
            }
        }

        private void DoBTextbox_Leave(object sender, EventArgs e)
        {
            if (DoBTextbox.Text == "")
            {
                DoBTextbox.Text = "Birthday";
                DoBTextbox.ForeColor = Color.FromArgb(190, 62, 66);
            }
        }

        private void AddressTextbox_Leave(object sender, EventArgs e)
        {
            if (AddressTextbox.Text == "")
            {
                AddressTextbox.Text = "Address";
                AddressTextbox.ForeColor = Color.FromArgb(190, 62, 66);
            }
        }

        private void PhoneTextbox_Leave(object sender, EventArgs e)
        {
            if (PhoneTextbox.Text == "")
            {
                PhoneTextbox.Text = "Phone Number";
                PhoneTextbox.ForeColor = Color.FromArgb(190, 62, 66);
            }
        }

        private void EmailTextbox_Leave(object sender, EventArgs e)
        {
            if (EmailTextbox.Text == "")
            {
                EmailTextbox.Text = "Email";
                EmailTextbox.ForeColor = Color.FromArgb(190, 62, 66);
            }
        }

        private void IDPersonalTextbox_Leave(object sender, EventArgs e)
        {
            if (IDPersonalTextbox.Text == "")
            {
                IDPersonalTextbox.Text = "ID Personal";
                IDPersonalTextbox.ForeColor = Color.FromArgb(190, 62, 66);
            }
        }

        private void AddButton_MouseMove(object sender, MouseEventArgs e)
        {
            AddButton.BackColor = Color.FromArgb(199, 80, 87);
        }

        private void AddButton_MouseLeave(object sender, EventArgs e)
        {
            AddButton.BackColor = Color.FromArgb(190, 62, 66);
        }
        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            int count = 0;

            if (FullNameTextbox.Text == "Full Name" || FullNameTextbox.Text == "")
            {
                errorProvider1.SetError(FullNameTextbox, "Please enter Full Name!");
                count++;
            }
            else
            {
                errorProvider1.SetError(FullNameTextbox, null);
            }

            if (DoBTextbox.Text == "Birthday" || DoBTextbox.Text == "")
            {
                errorProvider1.SetError(DoBTextbox, "Please enter Birthday!");
                count++;
            }
            else
            {
                errorProvider1.SetError(DoBTextbox, null);
            }

            if (AddressTextbox.Text == "Address" || AddressTextbox.Text == "")
            {
                errorProvider1.SetError(AddressTextbox, "Please enter Address!");
                count++;
            }
            else
            {
                errorProvider1.SetError(AddressTextbox, null);
            }


            if (IDPersonalTextbox.Text == "ID Personal" || IDPersonalTextbox.Text == "")
            {
                errorProvider1.SetError(IDPersonalTextbox, "Please enter ID Personal!");
                count++;
            }
            else
            {
                errorProvider1.SetError(IDPersonalTextbox, null);
            }


            if (PhoneTextbox.Text.Length > 0 && PhoneTextbox.Text != "Phone Number")
            {
                foreach (char item in PhoneTextbox.Text)
                {
                    if (item >= '0' && item <= '9')
                    {
                        errorProvider1.SetError(PhoneTextbox, null);
                    }
                    else
                    {
                        errorProvider1.SetError(PhoneTextbox, "Only accept number!");
                        count++;
                    }

                }
            }
            else
            {
                errorProvider1.SetError(PhoneTextbox, "Please enter phone number!");
            }

            if ((MaleCheckbox.Checked == false && FemaleCheckbox.Checked == false) || (MaleCheckbox.Checked == true && FemaleCheckbox.Checked == true))
            {
                errorProvider1.SetError(FemaleCheckbox, "Please enter only one!");
                count++;
            }
            else
            {
                errorProvider1.SetError(FemaleCheckbox, null);
            }

            string pattern = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
            if (Regex.IsMatch(EmailTextbox.Text, pattern))
            {
                errorProvider1.SetError(EmailTextbox, null);
            }
            else
            {
                errorProvider1.SetError(EmailTextbox, "Please enter email format!");
                count++;
            }

            for (int i = 0; i < InfoStaffGridView.Rows.Count; i++)
            {
                if (IDTextbox.Text == InfoStaffGridView.Rows[i].Cells["ID"].Value.ToString())
                {
                    MessageBox.Show("This staff already exist", "Notification", MessageBoxButtons.OK);
                    IDTextbox.Text = "";
                    IDTextbox.Focus();
                    return;
                }
            }


            if (count==0)
            {
                if ((MaleCheckbox.Checked == true && FemaleCheckbox.Checked == true) || (MaleCheckbox.Checked == false && FemaleCheckbox.Checked == false))
                {
                    MessageBox.Show("Wrong sex!", "Notification", MessageBoxButtons.OK);
                    return;
                }
                else if (MaleCheckbox.Checked)
                    Sex = "Nam";
                else
                    Sex = "Nữ";

                DateTime DayofBirth = DateTime.Parse(DoBTextbox.Text);
                string sqlFormattedDate = DayofBirth.ToString("yyyy-MM-dd HH:mm:ss.fff");
                AccountDAO.Instance.AddInfoStaff(IDTextbox.Text, FullNameTextbox.Text, sqlFormattedDate, AddressTextbox.Text, PhoneTextbox.Text, IDPersonalTextbox.Text, EmailTextbox.Text, Sex);
                if(PicturePath!="")
                {
                    imageToByteArray(PicturePath, IDTextbox.Text);
                }
                else
                {
                    string query = "update infostaff set avatar='0x89504E470D0A1A0A0000000D49484452000000E1000000E10803000000096D2248000001536943435069636D000018956360603C91939C5BCC24C0C0909B575214E4EEA4101119A5C0FE88819941848193818F413631B9B8C037D82D84818181A138B1BC38B9A4288701057CBBC6C008A22FEB6624E6A5CC9DC860EBD0B0C1D6A144A771DE52A53E06FC803325B538998181E1030303437C724151090303230F0303034F794901882DC1C0C02052141119C5C0C0A80362A743D80E207612841D02561312E4CCC0C098C1C0C090908EC44E426243ED0201D6D2207727648794A45694806867670306501840443F8780FDC62876122196BF8081C1E2130303733F422C691A03C3F64E0606895B083195050C0CFCAD0C0CDB8E2497169541ADD1626060A861F8C13887A994B999E5249B1F871097044F12DF17C1F322DF24B264F4149C55D66866E9D519BFB6DC6C7FCD2DDCD72CA42C463C4536A7AD34ACAEB7436792D99CD5CB7B36DDDE37F3D4F1EBA94FCA3FFEFCFF1F00478364E5919747F9000000E1504C5445FEBC20FFFFFF212121000000F6F6F6FFBF20FFC1201F2021FFBC201D1F211E1E1EFFC320191919000E211C1E21101010151515090909000022161B21001021181C21262626EBEBEBBABABA0F1721CBCBCBAEAEAE555555000D22E5E5E59F9F9FDCDCDC3D3D3D0005205C5C5C797979888888C5C5C5081421919191303030A7A7A7494949383838D19C21EDB121656565717171B58720A17920E8AE21322B224A3D20906E213E3322866620DCA4207C6022957120C49320272621D5A01F6B5323B98B204F42214D40225A4A21413623584720735C21342D210C1A1F3A3421131623A533E26900000FF749444154789CED5DFB5BA24C1B56708604C503985162C6D6526B5A6A072D4BDB727BF7FBFFFFA0EF425718E600A8306057F7B5FBFEF0C626B733CF719EE7995CEE1BDFF8C637BEB10F38C8E500001042B0FC03010069BF528C7018E572FD496F3A180C97180CE6D3DE68F9937D670A205472AF83F1EC5EB22CB3ACEBBABD84AEEBA6A5DFBDCD1EE613A8C07D6509201CCDC7777553373455120848C58666E856FDFE61DA87001CA4FDBE1B02C0DCEBF3875D3654921A86C6FFCCC6FD70928369BFF32600CAE4E1D3B2692B4785D4B0AD8FE791B22FDB15E6E66FF5088BE7876AD717D3DC3E7084B9C167B9B121BD151AE6E320F31C8132B8D3375D3E0FC5F2E720DBAA55E93D96B7E7E740353F7B30B37A15E69EF4EDF6278A46F9A99F4DBD7AA0F4EEEC9DF93930A4A992361B1AE0737DB70DEAA1581F674FE380DCAC1C133F07F6EF7EC62882FE473C3B740DED6E9429618423558B95A02034EC5E862882D1CBEE3A1487AABF668622E8DFC5BD820E8AF6243314EFE25F4107AA31CA86BA01EF46220405A1F19236B72594B19E104141301619888CE1DC4A8CA020980FA98B22E8EB51E3DCED28F6D21645384B428D7A28A62D8A7090E41E75608FD3DDA7FD9762C20CA5F2244D82CA43BCDE280DDA22C54504FD7AE20405C19CA6A76CE053B26A6605F523B578188CCA895A8A35ACD416118E9372D7FC682CD262D82F72594241B05252A770909C43EA87F1948E3A55120A9A4814857E1A04C16BD2EE8C07739E862486E999524D5CA256DA9DA1364BC560DC05396C15B1757ADC2E14DAC7A72DB112E59BA8CA010FD553E017B8494BE2793BEFA2732E32D7B156699DFE6C37DBC727B787229BA39E824984CF6C9754EC22FC961CCF44EA8315F1B2E93E5438BA6272349EF86F53F8C1CCE18B97790217148AB2785EF03F7552612CB6FA973BC1DCC860997BF1842498CFFF2228CA9523E2A9E61943662DEE693730651D53D0099214E56A87F6D88F1AF5B7EADCED05D35688A77482F9FCA58FA25C6BD31FFB415D4563CC5B10158618566F5804F3F95615FD268E598F5DD164B171CF9B21A0C7BEB25860BD783EDFAC79AA92BDD4F9364DA3165F383B6EE0D5A4EF518610AEE08962B515E93104FA84AF20823935AE28758308E6F3D7EBD5111942B84297B24F79DB7CF840553422A9FF7D38F9B73A95F3C0C78E298B680FF94650F444B07C1D4C309FFF2789B566F063944534F8E64D0F72F734555A63AB8F7FB85C9A82EA6DC86347E4226AEF9C95A944F368C490A5C9E73BCB57675B8A350E0975AAFEE5CBB04F0B2C4A67612F9ECF9FC982205F853E7641987DC9E6CA104C680C6B148F9BF6EAD5603DE3E027B94DEB5CE5104C69E6307CF3AD242C4CE33A9114852157930F0794E050AEE26258E8743AD8FF6B8A61C6708516A14DF9461760486388D98A9F3F96D98933DF8A150E65410C27983FAFE2BFDEE4EAD4C0678AC12FF93CB142575CE30A0D935A25195748EDA3D3137C839F124194F9CA95212D76F22990B6880279FFDB2A660D8FAF57CFFCF26F004210CB5CCFBBE11F8A4B53415469A1EA63287AAB785EAD5CA0542EDD675A6858423A6E9C19D29C36D4A3B9F51314BD8D795141BF89FC09F210EAB677D266F84E63E8EDB3B688C35537973E864DDF43BF0219720D2E9405E5C80259C34B82E10FFA1A5EF81E3ACC10C3DF1486C89BB70886AE8538AFA07278C812578A1CF265480B2D105D5A2219AE2DBF4F9736B187BC0C014597F26548CB4395DC9D58A8910CD77ECC8F1292086033FC45D8C30C30442CF915C9706D0AAE509FA650F13FE4B93FE74470C197217CA431945D1FF48629878E4B8D84915DFF439E4524FDD20C30143C457142105CCBE84F7F6C71E47BC8DDE6F942850881B3C010318804C335F9CB9A20A0CAF49A26ABD45C5479CA3340049F348688EB8D2FA2AB669D1C131AE3A3BA060942C8189F2FC303F0493DFF45E4C82F896E5CD55EAA48D4136F7629041D7D94EA2E65324432DE28C52B97F9CA08F8D318478E7F70751AEC776784A12FE57DE286178897B6CAA1C99590A41CA9493927BD0F72748658A6E6E8F6FAEAFAE604599CB5A752BBA0D0F2403AA54B863CE590C5B0FA23F0CDBD5C76706695B684823ECF024341FC19F4E65E2A3BE898D13DDDC0180EB2B04B05F930E0CD0B88860C38866B96A815191961182861B78891936BD4537C075D22CDB6849D1186F4746FA1D96C36FD079F72B5D36EB79BCD267E687C432F55E07DBCC66628D78EF3F942A1D9393E3A39BD38BF6975CFAEAF0EE552A586B929B253F356A9CA8757D767DDD6CDF9C5E9C9D171A7704EAF2D1204FB39230C0559BEE95EAD02C45AA55A2D95E425984F3B2895AAD5CAEADFD0B7A87380C8B74128A86A4FAED255C58EE07C441A5897980C38170AA7C050FBF3E519F2ADA24DBCDD8904DF9E844D1BBAA46251551B0DCD8746A3A1AA456A410095E16F9EFDA47D21F4BDA4A2DAD00C5B37CBA6656A87771FF76F8BD96C36FBB3C26C367B5FFCBEFF7CD174CB344DDD36B4861AD8BFA17EF2E317D64BA23AC4FE7B797C9B8D8783696FD2EF2FFD20001508977F9DFF2A703DFEAA3F7A9DCE870F7F161F2F5AD9B40DC6F025A9C89521E32D8A9A5DB6CCFBA7E17C32EA2B4B32EEF039F6165B0DAB73269F8D26D3E1F8BE6C950D8DFC0093E3413E18FD47BE4051B3ADBBD9736FA428DB0FD573B82ACA68FA3C93EAF8242D9E07F9802C81D6CAC26C30CAC534450F38D3D0861FB68D7E0CCFA66730F157264A467D36ED2BF18E0804004E9E518E36C7426830F195D334CC713F91596B0082A1E19EE3D9438E0C7DF5B3DADF4972F3B960FF714D91A763EA2BD4573F129D78045CBDDDE0D8F2ECAB1036139E94A3AC9B8DD54F7EBB140E3D86891B62B71C5992F81944B4E7A97897F087296E650BC7BA2FB4244A3292FE343752D307DC0451410B86CC5EA29F057AAE4470CCD4F84A31B464FB759485FB6D6A6FDC62604543184A5A920A00F690E61C8E65C2BE9620FB21B9AFF6E000ADFAB078A91ABCCABB9E9CD3AF3CA34D80DC8E2EF0DEC3C67D521F0C7B261A5D687F380922C46BA0CBCFC97C32E86BBE7C50E2B6770DF88455084B49D549DC63459EBC041190B5975612932AC10CAF97E776FE4466DAD4CFD8E78D1EC027A221A0F19B0B436AC38C167B0CA53C58C41729F199A40807B4861923E68E7938A6351EE95CB629A04F8732EE635CC50338A676C3F36978664D538893A24227C8A7FB899A2C5D427B89691037C8CD58E38B789C758339BD8D7B396F34167B0572BF99A36FD4C7E48F6714DCDEA3148DDEEE7202FB8F01B37DACC4F3C2078A1D702AA35ABBC6E1074ACF089A3F95FC4169C878A8A239DEE93B3E808372E0D964F22691D189EF417FDBE1421500C6A49DF723C9707485BF61D3F335A9A76CA90E60FF3E7C76BD1537230C116698A9DB7A1EB0F71261D464C2EE77A459899235DB66A72A4333CAED0A490FDE8D56A360081BEF54D85F441CA599A873CA1E9EB484EC16F7AAD6C3463EDC019C1EBA3BB4CAAE6E5BFEEE24437D85D65AE9F2AB555B5E65A1FE318AAEF40018BBF77FC8E26DE7369063828B0846ECB1BA724D3E752A98BD65AC0F239E0A1F40E40297D2B27CB81DC451D2932218A4672AB5CB652D6CA78B2CE3EF49947B7F40EEC1BB61A876F6AF37A873C39ED4672797DF6F307441493C77ABEF2FBD394F0DEB1984BE8BF2FAE1CE759745A48AFAF88C35834FB213BAA4854823BAEFD545ABB63BD735EF555E42EEFD017D4F0285DAA17FF2C0499531A0CE9825B48877547B55ADF8A705380DCCEE975F346723B6E10070FEE27E6BE494C17CE196B18CC9949EC001CD54C8628B6C0F39BEF2A451B31F581A47992C2CD7BE56A8CD1A3F2BD465541FB7F50C83008AB4EEDF1ABD73E2D2D31392FD1FF5C638D87FB25CE34359C07FA02F6339018B419D8CECAA3E029D96F766AA7E37C739C2DCB3E669665C02511CD1C6D84A8D04323694C26031685CD009327C56B5FE0E8057560494DC50F26EC6288981AD5EED334A0FC6FF62AF8A460B30DC170B9E16544087CFAABAF13C5A5EAB0A001C3D946DF7FB928989AE04685D1856DC8725644D69F58AD9D9B346A78B089164D88BE124971B0D163662766A42E028C2157E91C2586CC44B5019E3B6B0D60D9802E9E2081D0FEC5C38AA69A68E548F56C58B28BF267F4C7A38F18EDE0513DC2315831AEC509C0ABEEFDF57D85D126F220C8D5AA229108E6A3DCEB652800715C1BAC187C269B546B5DB25B115613C984B9198C01BE789299862C90BDA34E4008E9722C9B1245E07F66392BFA58B53B4633CF6C642FB8001AB0C9C5EF90449AE8AADCDF8392028D6E36A9DC5D5CCE6041DFFABE54EA02F8995DB503D4C430BA3586C8C622188AB99CDB6A887F6E9D9AA7FBDFB2B74862403F82A6A8B786E9EF5E748375032040AC72727C791CC0303D798468DA50E4479F67933819E5AE228E0A3A2EBBB4FAA0313DFD56A95909EFBA4D1C6B4B2BA7BFA14F8EE2229850F1F4D18F8D00CE37D475184BE7BB9E4D2B63A223EE01309F4E14EA2087BBE23DF28334A13071E69D4774A69F405548F6E6508E3073694A058DC3E1A06CA0CCD90864DF6E08526164B696F5B2FA2E2BBDF509677B16471021F87AD6F1B48C1575F7D6726847085732CAF51DFB67EC037F12A646E0E5714B04952D2763740FB855096D3A68502B78AC5972D12FD70983D43E1019F3BA87D6CCC10F88BAC2B61C3F039A3804FA6B79F366C12047D0915C2D0F95CDC410C5B3237F56DFEFA3233227EFA923E8881591B65500156831C61DA3F771043CFA4F2069583CAD09F7A0A1EE295126EF0FCA21A5DA1C2A94FCB60F3D6B38236719CA1DD47DDA313EC3EF18C598A35C849B5110F87411F3BECCDE6123A73C3718642395A611FDEAB92D125A42DA26045B01910EF558972BD4A3AA02CA2540ECD122B0FF8717D844B45D2C20FB2AE48B226C114E110AFAFCCA22D5C8336CB55D502CB88E19CA8100CBFC629459C51CEF81B415D58F095AC420EBFC6294550AFA10B308B606210E508A1376CA58A02F568D2786731EC536EA2CEA4C3E6E1965AC3683306A180474AF96894AB7D5204E5F22B0726DDF22F28C595950C6567A86054BED172530AD9B499657F660D8A5F232C735344B4A80CA985798759C991B2403389C272F8186616E1945AE11CE11AB89451101875B60DC1574B0726F44B9A33ECB1AD4104C26B18EFBE518B8C6E9FA0EB6F3302FAFC6F073AA250E13BBD463DAB91210A4A80B18635585384542DB30FB6228F5EC24B402AFFD336B0C76AC8C9B843B302DDAD59A2F1F8CF597B61B554ED81180609E2BA30CC7F02834216D27EFB28A0DE16B1DEA7E6DC29E066F66D663BAE7011C050900E73B911BB7739D3C1AF07B6AA7128E6C082DD8F9679A77405F2D6521439EA208F35C3A815BCE982BCB5D4C790311358D80BB77B05468CB86618D09A4A5CFB9A5104295341C805FCAC9491FA993034AB41AA26886125F3A1D30A78654674867B622C5657B66FC530E0469F6C817A43542486FBE077E7837DEF1086FB61F099D9A8080CB76A194801975B33DC0F9726C4A9096498E5331914E4E5BA5119EE87D3161C037F33DC0F6CCFF0EBCBE1D7D7A55FDF1E7E7D9F26FBC7322B300F6742197EF9D8A2B265B328776C1D1FEE4942788718BFD4CA17F601EDE07C69D00F65E2A2FB4C823ED02012C32F816F86FB8F6F86FB8FAFCFF0FFB16AC8F623A0CD690000000049454E44AE426082' where id='"+IDTextbox.Text+"'";
                    DataProvider.Instance.ExecuteQuery(query);
                }
                pictureBox1.BackgroundImage = null;
                IDTextbox.Text = "";
                FullNameTextbox.Text = "";
                DoBTextbox.Text = "";
                AddressTextbox.Text = "";
                PhoneTextbox.Text = "";
                IDPersonalTextbox.Text = "";
                EmailTextbox.Text = "";
                MaleCheckbox.Checked = false;
                FemaleCheckbox.Checked = false;
            }
            LoadInfoStaff();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            int count = 0;
            if (FullNameTextbox.Text == "Full Name" || FullNameTextbox.Text == "")
            {
                errorProvider1.SetError(FullNameTextbox, "Please enter Full Name!");
                count++;
            }
            else
            {
                errorProvider1.SetError(FullNameTextbox, null);
            }

            if (DoBTextbox.Text == "Birthday" || DoBTextbox.Text == "")
            {
                errorProvider1.SetError(DoBTextbox, "Please enter Birthday!");
                count++;
            }
            else
            {
                errorProvider1.SetError(DoBTextbox, null);
            }

            if (AddressTextbox.Text == "Address" || AddressTextbox.Text == "")
            {
                errorProvider1.SetError(AddressTextbox, "Please enter Address!");
                count++;
            }
            else
            {
                errorProvider1.SetError(AddressTextbox, null);
            }

            if (IDPersonalTextbox.Text == "ID Personal" || IDPersonalTextbox.Text == "")
            {
                errorProvider1.SetError(IDPersonalTextbox, "Please enter ID Personal!");
                count++;
            }
            else
            {
                errorProvider1.SetError(IDPersonalTextbox, null);
            }


            if (PhoneTextbox.Text.Length > 0 && PhoneTextbox.Text != "Phone Number")
            {
                foreach (char item in PhoneTextbox.Text)
                {
                    if (item >= '0' && item <= '9')
                    {
                        errorProvider1.SetError(PhoneTextbox, null);
                    }
                    else
                    {
                        errorProvider1.SetError(PhoneTextbox, "Only accept number!");
                        count++;
                    }

                }
            }
            else
            {
                errorProvider1.SetError(PhoneTextbox, "Please enter phone number!");
            }

            if((MaleCheckbox.Checked ==false && FemaleCheckbox.Checked==false) || (MaleCheckbox.Checked == true && FemaleCheckbox.Checked == true))
            {
                errorProvider1.SetError(FemaleCheckbox, "Please enter only one!");
                count++;
            }    
            else
            {
                errorProvider1.SetError(FemaleCheckbox, null);
            }


            string pattern = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
            if(Regex.IsMatch(EmailTextbox.Text,pattern))
            {
                errorProvider1.SetError(EmailTextbox, null);
            }    
            else
            {
                errorProvider1.SetError(EmailTextbox, "Please enter email format!");
                count++;
            }

            if (count==0)
            {
                if (MessageBox.Show("Do you really want to change this account?", "Notification", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    string Sex;

                    DateTime DayofBirth = Convert.ToDateTime(DoBTextbox.Text);
                    string sqlFormattedDate = DayofBirth.ToString("yyyy-MM-dd HH:mm:ss.fff");

                    if (MaleCheckbox.Checked == FemaleCheckbox.Checked)
                    {
                        MessageBox.Show("Wrong Sex", "Notificaiton", MessageBoxButtons.OK);
                        return;
                    }

                    if (MaleCheckbox.Checked == true)
                    {
                        Sex = "Nam";
                    }
                    else
                    {
                        Sex = "Nữ";
                    }

                    AccountDAO.Instance.EditInfoStaff(IDTextbox.Text, FullNameTextbox.Text, sqlFormattedDate, AddressTextbox.Text, PhoneTextbox.Text, IDPersonalTextbox.Text, EmailTextbox.Text, Sex);
                    if (PicturePath != "")
                    {
                        imageToByteArray(PicturePath, IDTextbox.Text);
                    }
                    this.Close();
                }
            }
        }
        string PicturePath = "";
        private void UploadButton_Click(object sender, EventArgs e)
        {
            Thread t = new Thread((ThreadStart)(() => {
                OpenFileDialog openfiledialog = new OpenFileDialog();

                openfiledialog.Filter = "Image files | *.png; *.jpg";
                openfiledialog.FilterIndex = 1;
                openfiledialog.RestoreDirectory = true;

                if (openfiledialog.ShowDialog() == DialogResult.OK)
                {
                    PicturePath = openfiledialog.FileName;
                    pictureBox1.BackgroundImage = Image.FromFile(PicturePath);
                }
            }));
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
            t.Join();
        }
    }
}
