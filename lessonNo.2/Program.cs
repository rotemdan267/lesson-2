using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lessonNo._2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region region
            string currentTime1 = DateTime.Now.ToString("HH-mm");
            int currentHour1 = DateTime.Now.Hour;
            while (Convert.ToInt32(currentTime1) < 9)
            {

            }

            /*
                #region
                #endregion
                מאפשר לכווץ קטע קוד. לא משפיע על הפעילות של הקומפיילר. 
                הקוד יבוצע כרגיל. נועד בשבילי שיהיה לי נוח בעין, אם אני רוצה לכווץ קטע מסוים.
               “while loop”
               במקרה הזה זו הכותרת של הקטע המכווץ – כשאכווץ אותו בעצם תופיע לי על המסך רק הכותרת במקום כל הקטע קוד.
             */

            #endregion

            #region DateTime
            string currentTime = DateTime.Now.ToString("HH-mm");
            // מביא את השעה הנוכחית (HH) 
            // ואת הדקות הנוכחיות (mm)
            // ToString ממיר לסטרינג


            int currentHour = DateTime.Now.Hour;
            // מביא את השעה הנוכחית, בצורת int

            #endregion

            #region do while

            int x = 9;

            do   //  הבלוק פקודות מתבצע  בפעם הראשונה ללא קשר לתנאי
            {    // ומתחיל לבדוק את התנאי החל מהפעם השניה 
                x++;
            }
            while (x < 10);

            #endregion

            #region כללי כתיבה בבוליאני, ו-! ומשמעותו

            bool a = 5 > 2; // a = true
            // אם אני מציב בתוך משתנה בוליאני "תרגיל" שתוצאתו תהיה אמת או שקר,
            // התוצאה פשוט תוצב במשתנה


            if (!a) // if(a == false)

            if (a) // if(a == true)

            a = !a; // a = the opposite of "a" = false
            a = !a; // a = the opposite of "a" = true

            #endregion

            #region  null

            string str = null; // null - ערך ריק, אבל יש ערך ואפשר להשתמש ב-str
            string str1; // כרגע אי אפשר עדיין להשתמש במשתנה כי אין לו ערך

            #endregion
            
            #region "for" loop

            for (int i = 0, j = 10; i < j && j != 4; i++, j--)
            {

            }

            /*
                בלולאת "פור" אפשר להגדיר בתחילתה יותר ממשתנה אחד, להפסיק ביניהם עם "," וכן
                אפשר שיהיה יותר מתנאי אחד על מנת להיכנס ללולאה בעזרת && או || וכן
                אפשר שייעשו יותר פעולות בסיום כל פעולה של הלולאה:
                i++, j--
                הפסקה ביניהם עם ","
             
            */


            for (; ; ) // לולאה אין סופית = while(true)
            {

            }

            #endregion

            #region exercise 1

            Console.WriteLine("Please enter a number bigger than 3");
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num * 2; i++)
            {
                if (i == 0)
                {
                    continue;
                }
                Console.WriteLine(i);
                if (i > 10)
                {
                    Console.WriteLine("END");
                    break;
                }
                if (i == num * 2 - 1)
                {
                    Console.WriteLine("END");
                }
            }

            #endregion

            #region exercise 2

            for (int i = 0, j = 10; i <= 10; i++, j--)
            {
                Console.WriteLine(i + j);
            }

            #endregion

            #region exercise 3

            int counter = 0;
            while (true)
            {
                counter++;
                Console.WriteLine("Please enter number");
                int num = int.Parse(Console.ReadLine());
                if (num == 23)
                {
                    break;
                }

            }
            Console.WriteLine(counter);

            #endregion

        }
    }
}
