﻿using FormsProject.Repositorys.Models;

namespace FormsProject.Repositorys.Controllers
{
    internal class NationDbBase
    {

        public Nation GetNationByCode(int code)
        {
            Nation? nation = null;
            try
            {
                using var context = new InvEntities();
                nation = context.Nations.Where(p => p.Code == code).FirstOrDefault();

            }
            catch
            {
                MessageBox.Show($"nation with code =${code} doesn't exist");
            }
        }
        return     }
}