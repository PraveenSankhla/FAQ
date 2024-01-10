using FAQ.Client.Services;
using FAQ.Shared;
using System.Collections.Generic;
using System.Net.Http;

namespace FAQ.Server.Bussiness
{
    public class FAQManager
    {
        public static List<FAQs> GetFAQ(FAQs faq)
       {
            List<FAQs> list = new List<FAQs>();
            try
            {
                List<FAQs> result = new List<FAQs>
                {
                    new FAQs
                    {
                        Topic = "Bootstrap",
                        Category = "General",
                        Question = "What is Bootstrap?",
                        Answer = "A CSS Framework for creating responsive web apps for multiple screen sizes."
                    },
                    new FAQs
                    {
                        Topic = "CSharp",
                        Category = "General",
                        Question = "What is C#?",
                        Answer = "A general purpose object oriented language that uses a concise, Java-like syntex."
                    },
                    new FAQs
                    {
                        Topic = "Javascript",
                        Category = "General",
                        Question = "What is Javascript?",
                        Answer = "A general purpose scripting language that executes in a web browser."
                    },
                    new FAQs
                    {
                        Topic = "Bootstrap",
                        Category = "History",
                        Question = "When was Bootstrap first released?",
                        Answer = "In 2011."
                    },
                    new FAQs
                    {
                        Topic = "CSharp",
                        Category = "History",
                        Question = "When was C# first released?",
                        Answer = "In 2002."
                    },

                    new FAQs
                    {
                        Topic = "Javascript",
                        Category = "History",
                        Question = "When was Javascript first released?",
                        Answer = "In 1995."
                    }
                };

                if (faq.Topic != null && faq.Category == null)
                {
                    list = result.Where(result => result.Topic == faq.Topic).ToList();
                }
                else if (faq.Category != null && faq.Topic == null)
                {
                    list = result.Where(result => result.Category == faq.Category).ToList();
                }
                else
                if (faq.Topic != null && faq.Category != null)
                {
                    list = result.Where(result => result.Category == faq.Category && result.Topic == faq.Topic).ToList();
                }
                else
                {
                    list = result.ToList();
                }
                return list;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static List<Filter> GetTopic()
        {
            List<Filter> topics = new List<Filter>();
            try
            {
                topics.Add
                (
                    new Filter
                    {
                        Id = "1",
                        Title = "Bootstrap"
                    }
                );
                topics.Add
                (
                    new Filter
                    {
                        Id = "2",
                        Title = "CSharp",
                    }
                );
                topics.Add
                (
                     new Filter
                     {
                         Id = "3",
                         Title = "Javascript",
                     }
                );
                return topics;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static List<Filter> GetCategory()
        {
            List<Filter> Category = new List<Filter>();
            try
            {
                Category.Add
                (
                    new Filter
                    {
                        Id = "1",
                        Title = "General"
                    }
                );
                Category.Add
                (
                    new Filter
                    {
                        Id = "2",
                        Title = "History",
                    }
                );
                return Category;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
