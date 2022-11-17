using System.Collections;
using System.Collections.Generic;
using Web.Domain;

namespace Web.Dao
{
    public class QuestionDao
    {
        public IEnumerable<Question> getAll 
        { 
            get
            {
                return new List<Question>()
                {
                    new Question("Як називається секція коду, яка йде після блоків try-catch?", new List<Answear>()
                    {
                        new Answear("finalise",false),
                        new Answear("finally",true),
                        new Answear("final",false),
                        new Answear("finsh",false),
                    }),
                    new Question("Файл Web.config використовується для ", new List<Answear>()
                    {
                        new Answear("Налаштування веб-браузера",false),
                        new Answear("Налаштування веб-сервера",false),
                        new Answear("Налаштування часу виклику серверного модуля коду",false),
                        new Answear("Зберігання інформації та визначення змінних для програми",true),
                    }),
                    new Question("На якій мові програмування пишуть код для ASP.NET ", new List<Answear>()
                    {
                        new Answear("JS",false),
                        new Answear("Pascal",false),
                        new Answear("java",false),
                        new Answear("С#",true),
                    }),
                    new Question("Оберіть правильне твердження 'pablic delegate R D<out R>(): '", new List<Answear>()
                    {
                        new Answear("Делегат є коваріарним",true),
                        new Answear("Делегат є контраваріарним",false),
                        new Answear("Код не скомпілюється",false),
                        new Answear("Правильної відповіді немає",false),
                    }),
                    new Question("ASP.NET - це", new List<Answear>()
                    {
                        new Answear("платформа для створення веб-додатків і веб-сервісів, що працюють під управлінням IIS",true),
                        new Answear("мова програмуваня",false),
                        new Answear("веб-застосунок",false),
                        new Answear("база даних",false),
                    }),
                     new Question("При Windows аутентифікації ASP.NET автоматично приєднується ...", new List<Answear>()
                    {
                        new Answear("FileAuthorizationModule",false),
                        new Answear("WindowsPrincipal об'єкт",true),
                        new Answear("UrlAuthorizationModule ",false),
                        new Answear("база даних",false),
                    }),
                     new Question("Як називається початковий проект?", new List<Answear>()
                    {
                        new Answear("XSS",false),
                        new Answear("XSP",true),
                        new Answear("XST",false),
                        new Answear("XSL",false),
                    }),
                     new Question("Який основний елемент веб-програми?", new List<Answear>()
                    {
                        new Answear("XML файл",false),
                        new Answear("windows Form",false),
                        new Answear("немає основного елементу",false),
                        new Answear("Web-форма",true),
                    }),
                    new Question("За замовчуванням ASP.NET зберігає ідентифікатор сеансів у", new List<Answear>()
                    {
                        new Answear("Не зберігає",false),
                        new Answear("Cookies",false),
                        new Answear("БД",false),
                        new Answear("Кеш",true),
                    }),
                    new Question("Яка з наступних струкутур данних найбільш підходить для відображення кількості студентів по группах", new List<Answear>()
                    {
                        new Answear("Dictionary<string, int>",true),
                        new Answear("List<string>",false),
                        new Answear("Enum",false),
                        new Answear("String[]",false),
                    })
					
					
                };
            }
        } 
    }
}
