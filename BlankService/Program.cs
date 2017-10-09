using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Topshelf;

namespace BlankService
{
    class Program
    {
        static void Main(string[] args)
        {

            HostFactory.Run(x =>                                 
            {
                x.Service<BlankService>(s =>                        
                {
                    s.ConstructUsing(name => new BlankService());    
                    s.WhenStarted(tc => tc.Start());              
                    s.WhenStopped(tc => tc.Stop());               
                });
                x.RunAsLocalSystem();                            
           
                x.SetDescription("A lazy service that doesn't do anything");       
                x.SetDisplayName("BlankService");                      
                x.SetServiceName("BlankService");                      
            });

        }
    }
}
