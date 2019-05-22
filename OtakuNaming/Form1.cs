using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtakuNaming
{
    public partial class Form1 : Form
    {
        string name;


        public Form1()
        {
            InitializeComponent();
        }


        private void Button1_Click(object sender, EventArgs e)
        {
            if (rbM_1.Checked)
            {
                name = "츠키노(달의)";
            }
            else if (rbM_2.Checked)
            {
                name = "아이노(사랑의)";
            }
            else if (rbM_3.Checked)
            {
                name = "소라노(하늘의)";
            }
            else if (rbM_4.Checked)
            {
                name = "미즈노(물의)";
            }
            else if (rbM_5.Checked)
            {
                name = "하나노(꽃의)";
            }
            else if (rbM_6.Checked)
            {
                name = "우츄-우노(우주의)";
            }
            else if (rbM_7.Checked)
            {
                name = "타이요오노(태양의)";
            }
            else if (rbM_8.Checked)
            {
                name = "호시노(별의)";
            }
            else if (rbM_9.Checked)
            {
                name = "오오모리노(숲의)";
            }
            else if (rbM_10.Checked)
            {
                name = "카게노(그림자의)";
            }
            else if (rbM_11.Checked)
            {
                name = "텐노(천국의)";
            }else if (rbM_12.Checked)
            {
                name = "유키노(눈의)";
            }

            if (rbD_1.Checked)
            {
                name += " 카케라(파편)";
            }
            else if (rbD_2.Checked)
            {
                name += " 텐시(천사)";
            }
            else if (rbD_3.Checked)
            {
                name += " 나미다(눈물)";
            }
            else if (rbD_4.Checked)
            {
                name += " 차카시(증거)";
            }
            else if (rbD_5.Checked)
            {
                name += " 유메(꿈)";
            }
            else if (rbD_6.Checked)
            {
                name += " 코코로(마음)";
            }
            else if (rbD_7.Checked)
            {
                name += " 시즈쿠(물방울)";
            }
            else if (rbD_8.Checked)
            {
                name += " 요-오세이(요정)";
            }
            else if (rbD_9.Checked)
            {
                name += " 온가쿠(음악)";
            }
            else if (rbD_10.Checked)
            {
                name += " 하카리(빛)";
            }
            else if (rbD_11.Checked)
            {
                name += " 사메(상어)";
            }
            else if (rbD_12.Checked)
            {
                name += " 켓쇼오(결정)";
            }
            else if (rbD_13.Checked)
            {
                name += " 사사야키(속삭임)";
            }
            else if (rbD_14.Checked)
            {
                name += " 오츠케(신탁)";
            }
            else if (rbD_15.Checked)
            {
                name += " 오마지나이(주문)";
            }
            else if (rbD_16.Checked)
            {
                name += " 이츠와리(사기꾼)";
            }
            else if (rbD_17.Checked)
            {
                name += " 이노리(기도)";
            }
            else if (rbD_18.Checked)
            {
                name += " 네코(고양이";
            }
            else if (rbD_19.Checked)
            { 
                name += " 미치시루베(안내자)";
            }
            else if (rbD_20.Checked)
            {
                name += " 쿠마(곰)";
            }
            else if (rbD_21.Checked)
            {
                name += " 호고샤(보호자)";
            }
            else if (rbD_22.Checked)
            {
                name += " 마호(마법)";
            }
            else if (rbD_23.Checked)
            {
                name += " 타카라(보물)";
            }
            else if (rbD_24.Checked)
            {
                name += " 타마시이(영혼)";
            }
            else if (rbD_25.Checked)
            {
                name += " 요오카이(여괴)";
            }
            else if (rbD_26.Checked)
            {
                name += " 키츠네(여우)";
            }
            else if (rbD_27.Checked)
            {
                name += " 오오카미(늑대)";
            }
            else if (rbD_28.Checked)
            {
                name += " 츠바사(날개)";
            }
            else if (rbD_29.Checked)
            {
                name += " 오미야게(선물)";
            }

            else if (rbD_30.Checked)
            {
                name += " 카이토오(괴도)";
            }
            else if (rbD_31.Checked)
            {
                name += " 하카이샤(지배자)";
            }

            MessageBox.Show(name,"당신의 이름",MessageBoxButtons.OK,MessageBoxIcon.None);

        }

    }
}
