using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class GamerManager : IGamerService
    {
        IUserValidationService _userValidationService;
        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }
        public void Add(Gamer gamer)
        {
            
            if (_userValidationService.Validate(gamer)==true)
            {
                Console.WriteLine("Record added.");
            }
            else
            {
                Console.WriteLine("Record not added.");
            }
        }

      

        public void Delete(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer)==true)
            {
                Console.WriteLine("Record deleted.");
            }
            else
            {
                Console.WriteLine("Record not deleted.");
            }
        }

      
        public void Update(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer)==true)
            {
                Console.WriteLine("Record updated");
            }
            else
            {
                Console.WriteLine("Record not updated");
            }
            
        }

        
       
    }
}
