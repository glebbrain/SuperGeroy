using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperGeroy.Tests
{
    class Text
    {
        /// <summary>
        /// Поиск и замена -> Регулярные выражения
        /// </summary>
        public class FindAndReplace_RegEx
        {
            public static string email()
            {
                return "test@testgu.ru"
                        + Environment.NewLine + "te.st@testgu.ru"
                        + Environment.NewLine + "t.es-t@testgu.ru"
                        + Environment.NewLine + "test@tes-tgu.ru"
                        + Environment.NewLine + "test@dev.tes-tgu.ru"
                        + Environment.NewLine + "ta_sd-es.t@dev.tes-tgu.ru"
                        + Environment.NewLine + "tasd-est@a.rutasd-est@a.ru"
                        + Environment.NewLine + "сусликихомячутся@a.rutasd-est@a.ru"
                ;
            }
            public static string telephone()
            {
                return "многотекста: +7 123 123 12 12 текст в тексте!"
                        + Environment.NewLine + "+7 (123) 123 12 12"
                        + Environment.NewLine + "+7(123) 123-12-12"
                        + Environment.NewLine + "Тест+7 987 654-32-10"
                        + Environment.NewLine + "8 123 123-12-12"
                        + Environment.NewLine + "Тест+7(123) 123 00-00Тест"
                        + Environment.NewLine + "Тест+7(123) 321 0000Тест"
                        + Environment.NewLine + "+7(123) 1231212"
                        + Environment.NewLine + "+7 1231231212"
                        + Environment.NewLine + "+71231231212"
                        + Environment.NewLine + "1231231212"
                        + Environment.NewLine + "81231231212"
                        + Environment.NewLine + "+11231231212"
                        + Environment.NewLine + "+11231231212"
                        + Environment.NewLine + "Тетест7999-888-44-55ТеСт79782434112Тестовый"
                        + Environment.NewLine + "12-12-25"
                ;
            }
            public static string url()
            {
                return "ftp://test.ru"
                            + Environment.NewLine + "http://test.ru"
                            + Environment.NewLine + "https://test.ru"
                            + Environment.NewLine + "https://test.ru?a=b"
                            + Environment.NewLine + "https://test.ru&a=b"
                            + Environment.NewLine + "https://test.ru/catalog/product/test"
                            + Environment.NewLine + "https://test.ru/catalog/product/test?price=10&count=1"
                            + Environment.NewLine + "ws://test.ru/catalog/product/test?price=10&count=1"
                ;
            }
            public static string ip()
            {
                return "0.0.0.0"
                        + Environment.NewLine + "ыаыва127.0.0.1ыаываыва"
                        + Environment.NewLine + "у фы цу ф8.8.8.8"
                        + Environment.NewLine + "255.255.255.255"
                        + Environment.NewLine + "198.0.0.1 фыва фыва "
                ;
            }
        }

        /// <summary>
        /// Форматирование -> Действие
        /// </summary>
        public class Format_Action
        {
            /* comboBox1:
                 0.  Действие
               + 1.  Разбить текст на строки по символу или тексту
               + 2.  Транслит
               + 3.  Все слова с Заглавной буквы
               + 4.  Все слова с Заглавной буквы без предлогов
                 5.  ----------------------------------------
               + 6.  Все прописью
               + 7.  Все Заглавной
                 8.  ----------------------------------------
               + 9.  Убрать лишние пробелы
               + 10. Количество символов в начало строки
               + 11. Перевернуть строку
                 12. ----------------------------------------
               + 13. Сменить раскладку QWERTY с RU на EN
               + 14. Сменить раскладку QWERTY с EN на RU
                 15. ----------------------------------------
               + 16. Сортировка строк от А до Я
               + 17. Сортировка строк от Я до А
               + 18. Случайная перестановка строк

               + 19. Сортировка слов в строке от А до Я
               + 20. Сортировка слов в строке от Я до А
               + 21. Случайная перестановка слов

               + 22. Сортировка букв в слове от А до Я
               + 23. Сортировка букв в слове от Я до А
               + 24. Случайная перестановка букв
                 25. ----------------------------------------
               + 26. Добавить текст перед строкой
               + 27. Добавить текст после строки
               + 28. Добавить текст перед словом
               + 29. Добавить текст после слова
               + 30. Добавить текст перед буквой
               + 31. Добавить текст после буквы
                 32. ----------------------------------------
               + 33. Исправление пунктуации
           */
            public static string act_1() { return "Много интересного и привлекательного текста, несущего в себе безграничные знания"; }
            public static string act_2() {
                return    "1  - А\r\n"
                        + "2  - Б\r\n"
                        + "3  - В\r\n"
                        + "4  - Г\r\n"
                        + "5  - Д\r\n"
                        + "6  - Е\r\n"
                        + "7  - Ё\r\n"
                        + "8  - Ж\r\n"
                        + "9  - З\r\n"
                        + "10 - И\r\n"
                        + "11 - Й\r\n"
                        + "12 - К\r\n"
                        + "13 - Л\r\n"
                        + "14 - М\r\n"
                        + "15 - Н\r\n"
                        + "16 - О\r\n"
                        + "17 - П\r\n"
                        + "18 - Р\r\n"
                        + "19 - С\r\n"
                        + "20 - Т\r\n"
                        + "21 - У\r\n"
                        + "22 - Ф\r\n"
                        + "23 - Х\r\n"
                        + "24 - Ц\r\n"
                        + "25 - Ч\r\n"
                        + "26 - Ш\r\n"
                        + "27 - Щ\r\n"
                        + "28 - Ъ\r\n"
                        + "29 - Ы\r\n"
                        + "30 - Ь\r\n"
                        + "31 - Э\r\n"
                        + "32 - Ю\r\n"
                        + "33 - Я\r\n"
                ; 
            }
            public static string act_3() { return "И слово1 в большое-слово2 на НеПоНяТнОеСлОвО по слову из слова не слово, а слово, но слово"; }
            public static string act_4() { return "И слово1 в большое-слово2 на НеПоНяТнОеСлОвО по слову из слова не слово, а слово, но слово"; }
            // 5. ----------------------------------------
            public static string act_6() { return "Все Слова В ПрописЬю"; }
            public static string act_7() { return "Все слОва на заглАвной"; }
            // 8. ----------------------------------------
            public static string act_9() { return "Убрать               лишние   пробелы"; }
            public static string act_10() { 
                return "Количество символов в начало строки\r\n"
                    + "хм интересно, а здесь сколько символов?\r\n"
                    + ",1+*-45=ХМ  интересно,  а  здесь  с к о л ь к о  символов?\r\n"
                ; 
            }
            public static string act_11() { return "Перевернуть строку: Я, оно, программа"; }
            // 12. ----------------------------------------
            public static string act_13() { return "рудз ьу! пдуикфшт скуфеу фш"; }
            public static string act_14() { return "Rjulf-yb,elm z cjplfv ghjuhfvve rjnjhjz j[dfnbn dtcm VBH!"; }
            // 15. ----------------------------------------
            public static string act_16_18() { 
                return    "ааааа бббб вввв цццц Дддд\r\n"
                        + "бббб вввв цццц Дддд ааааа\r\n"
                        + "вввв цццц Дддд ааааа бббб\r\n"
                        + "цццц Дддд ааааа бббб вввв\r\n"
                        + "Дддд ааааа бббб вввв цццц \r\n"
                ; 
            }
            public static string act_19_21() {
                return "ааааа бббб вввв цццц Дддд\r\n"
                        + "бббб вввв цццц Дддд ааааа\r\n"
                        + "вввв цццц Дддд ааааа бббб\r\n"
                        + "цццц Дддд ааааа бббб вввв\r\n"
                        + "Дддд ааааа бббб вввв цццц \r\n"
                ;
            }
            public static string act_22_24() {
                return "аяааяаа бцукббб вфавкнвв цфываццц яДчдхдзд\r\n"
                        + "бцукббб вфавкнвв цфываццц яДчдхдзд аяааяаа\r\n"
                        + "вфавкнвв цфываццц яДчдхдзд аяааяаа бцукббб\r\n"
                        + "цфываццц яДчдхдзд аяааяаа бцукббб вфавкнвв\r\n"
                        + "яДчдхдзд аяааяаа бцукббб вфавкнвв цфываццц \r\n"
                ;
            }

            // 25. ----------------------------------------
            public static string act_26_31() {
                return "ааааа бббб вввв цццц Дддд\r\n"
                        + "бббб вввв цццц Дддд ааааа\r\n"
                        + "вввв цццц Дддд ааааа бббб\r\n"
                        + "цццц Дддд ааааа бббб вввв\r\n"
                        + "Дддд ааааа бббб вввв цццц \r\n"
                ;
            }
            // 32. ----------------------------------------
            public static string act_33() { 
                return "Всем  привет . .  C  вами  SuperGeroy - программа : помощник ! В непростой  жизни  людей  работающиx за компьютерами и программистов , постоянно разрабатываемых программы . . ."; 
            }

        }
    }
}
