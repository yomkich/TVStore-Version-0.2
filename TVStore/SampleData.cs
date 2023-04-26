using System.Linq;
using TVStore.Models;

namespace TVStore
{
    public static class SampleData
    {
        public static void Initialize(TVContext context)
        {
            if (!context.TVs.Any())
            {
                context.TVs.AddRange(
                    new TV
                    {
                        Name = "Tuvio ULTRA HD DLED",
                        Company = "Tuvio",
                        Price = 21800
                    },
                    new TV
                    {
                        Name = "TCL 43P637 2022",
                        Company = "TCL",
                        Price = 21500
                    },
                    new TV
                    {
                        Name = "Hyundai H-LED",
                        Company = "Hyundai",
                        Price = 14000
                    }
                );
                context.SaveChanges();
            }
        }
    }
}