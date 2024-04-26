
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace قيصر
{
    class Ceaser
    {
        static string alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"; //الأحرف الإنجليزية 
        static char[] letter = alpha.ToCharArray(); // اسناد الأحرف إلى مصفوفة من نوع محرف
        static char[] input = null; //مصفوفة محارف للإدخال
        static string output = null; //النتيجة
        static int result = 0; //من أجل فك التشفير لمناقشة القيمة السالبة
        static int key = 3; //مفتاح شيفرة قيصر

        //دالة التشفير
        public static string Enc(string plainText)
        {
            input = plainText.ToUpper().ToArray(); // تحويل المتغير ضمن البارامتر الى أحرف كبيرة وإلى مصفوفة من أجل اسنادها إلى مصفوفة الادخال

            //حلقة عملية التشفير
            for (int i = 0; i < input.Length; i++)
            {
                for(int j=0; j < letter.Length; j++)//البحث داخل المصفوفة الفا عن الحرف الي مدخلو المستخدم 
                {
                    if (input[i]==letter[j])//اذا حصلنا ع موقع الحرف 
                    {
                        input[i] = letter[(i + key) % letter.Length];//الطول يعني 26 
                        break;
                    }
                }
                }
            //    //التعامل هنا كأرقام
            //    int plainIndex = Array.IndexOf(letter, input[i]); // يعني أن الحرف الحالي يتم البحث عن موقعه (انديكس) في مصفوفة الأحرف والنتيجة رقم يتم إسناده إلى متغير للحرف النص الأًصلي من نوع رقمي

            //    int encryptedIndex = (plainIndex + key) % letter.Length; //جمع المتغير السابق مع المفتاح والنتيجة باقي القسمة على طول مصفوفة الأحرف (26) ووضع النتيجة في متغير نتيجة التشفير من نوع رقم

            //    //تحويل الرقم الناتج الى حرف
            //    input[i] = letter[encryptedIndex]; //رقم المتغير السابق هو الانديكس لمصفوفة الأحرف الإنجليزية ووضعه النتيجة ضمن مصفوفة الادخال
            //}
            output = new string(input);//اسناد الحرف الى متغير الخرج مع مراعاة تحويله الى نوع نص
           return output; //الخرج
        }



        //دالة فك التشفير
        public static string Dec(string cipherText)
        {

            input = cipherText.ToUpper().ToArray();// تحويل المتغير ضمن البارامتر الى أحرف كبيرة وإلى مصفوبة من أجل اسنادها إلى مصفوفةالادخال

            //حلقة فك التشفير
            for (int i = 0; i < input.Length; i++)
            {
                //التعامل هنا كأرقام
                int cipherIndex = Array.IndexOf(letter, input[i]);// يعني أن الحرف المشفر الحالي يتم البحث عن موقعه (انديكس) في مصفوفة الأحرف والنتيجة رقم يتم إسناده إلى متغير لحرف النص الأًصلي من نوع رقم

                result = (cipherIndex - key);//عملية فك التشفير
                //مناقشة إذا كانت النتيجة سالبة
                while (result < 0)
                    result = result + letter.Length;//تحويل السالب إلى موجب بما يتوافق مع فك التشفير
                int decryptedIndex = (result) % letter.Length;//النتيجة باقي قسمتها على (26) والاسناد الى متغير رقمي
                //تحويل الرقم إلى حرف
                input[i] = letter[decryptedIndex];//المتغير الرقمي السابق هو انديكس لمصفوفة الأحرف ووضع النتيجة (حرف) ضمن مصفوفة الادخال
            }
            output = new string(input);//اسناد الحرف الى متغير الخرج مع مراعاة تحويله الى نوع نص
            return output;//الخرج

        }
    }
}
