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
                return    "1  - А"+ Environment.NewLine
                        + "2  - Б"+ Environment.NewLine
                        + "3  - В"+ Environment.NewLine
                        + "4  - Г"+ Environment.NewLine
                        + "5  - Д"+ Environment.NewLine
                        + "6  - Е"+ Environment.NewLine
                        + "7  - Ё"+ Environment.NewLine
                        + "8  - Ж"+ Environment.NewLine
                        + "9  - З"+ Environment.NewLine
                        + "10 - И"+ Environment.NewLine
                        + "11 - Й"+ Environment.NewLine
                        + "12 - К"+ Environment.NewLine
                        + "13 - Л"+ Environment.NewLine
                        + "14 - М"+ Environment.NewLine
                        + "15 - Н"+ Environment.NewLine
                        + "16 - О"+ Environment.NewLine
                        + "17 - П"+ Environment.NewLine
                        + "18 - Р"+ Environment.NewLine
                        + "19 - С"+ Environment.NewLine
                        + "20 - Т"+ Environment.NewLine
                        + "21 - У"+ Environment.NewLine
                        + "22 - Ф"+ Environment.NewLine
                        + "23 - Х"+ Environment.NewLine
                        + "24 - Ц"+ Environment.NewLine
                        + "25 - Ч"+ Environment.NewLine
                        + "26 - Ш"+ Environment.NewLine
                        + "27 - Щ"+ Environment.NewLine
                        + "28 - Ъ"+ Environment.NewLine
                        + "29 - Ы"+ Environment.NewLine
                        + "30 - Ь"+ Environment.NewLine
                        + "31 - Э"+ Environment.NewLine
                        + "32 - Ю"+ Environment.NewLine
                        + "33 - Я"+ Environment.NewLine
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
                return "Количество символов в начало строки"+ Environment.NewLine
                    + "хм интересно, а здесь сколько символов?" + Environment.NewLine
                    + ",1+*-45=ХМ  интересно,  а  здесь  с к о л ь к о  символов?" + Environment.NewLine
                ; 
            }
            public static string act_11() { return "Перевернуть строку: Я, оно, программа"; }
            // 12. ----------------------------------------
            public static string act_13() { return "рудз ьу! пдуикфшт скуфеу фш"; }
            public static string act_14() { return "Rjulf-yb,elm z cjplfv ghjuhfvve rjnjhjz j[dfnbn dtcm VBH!"; }
            // 15. ----------------------------------------
            public static string act_16_18() { 
                return    "ааааа бббб вввв цццц Дддд"+ Environment.NewLine
                        + "бббб вввв цццц Дддд ааааа"+ Environment.NewLine
                        + "вввв цццц Дддд ааааа бббб"+ Environment.NewLine
                        + "цццц Дддд ааааа бббб вввв"+ Environment.NewLine
                        + "Дддд ааааа бббб вввв цццц" + Environment.NewLine
                ; 
            }
            public static string act_19_21() {
                return "ааааа бббб вввв цццц Дддд" + Environment.NewLine
                        + "бббб вввв цццц Дддд ааааа"+ Environment.NewLine
                        + "вввв цццц Дддд ааааа бббб"+ Environment.NewLine
                        + "цццц Дддд ааааа бббб вввв"+ Environment.NewLine
                        + "Дддд ааааа бббб вввв цццц" + Environment.NewLine
                ;
            }
            public static string act_22_24() {
                return "аяааяаа бцукббб вфавкнвв цфываццц яДчдхдзд" + Environment.NewLine
                        + "бцукббб вфавкнвв цфываццц яДчдхдзд аяааяаа"+ Environment.NewLine
                        + "вфавкнвв цфываццц яДчдхдзд аяааяаа бцукббб"+ Environment.NewLine
                        + "цфываццц яДчдхдзд аяааяаа бцукббб вфавкнвв"+ Environment.NewLine
                        + "яДчдхдзд аяааяаа бцукббб вфавкнвв цфываццц" + Environment.NewLine
                ;
            }

            // 25. ----------------------------------------
            public static string act_26_31() {
                return "ааааа бббб вввв цццц Дддд" + Environment.NewLine
                        + "бббб вввв цццц Дддд ааааа"+ Environment.NewLine
                        + "вввв цццц Дддд ааааа бббб"+ Environment.NewLine
                        + "цццц Дддд ааааа бббб вввв"+ Environment.NewLine
                        + "Дддд ааааа бббб вввв цццц" + Environment.NewLine
                ;
            }
            // 32. ----------------------------------------
            public static string act_33() { 
                return "Всем  привет . .  C  вами  SuperGeroy - программа : помощник ! В непростой  жизни  людей  работающиx за компьютерами и программистов , постоянно разрабатываемых программы . . ."; 
            }

        }
    }
}
