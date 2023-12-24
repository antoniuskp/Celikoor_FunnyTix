using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace FunnyTix_LIB
{
    public class FilmStudio
    {
        #region DATA MEMBERS
        private Film film;
        private Studio studio;

        #endregion

        #region CONSTRUCTORS
        public FilmStudio(Film film, Studio studio)
        {
            this.Film = film;
            this.Studio = studio;
        }
        public FilmStudio()
        {
            this.Film = new Film();
            this.Studio = new Studio();
        }
        #endregion

        #region PROPERTIES
        public Film Film { get => film; set => film = value; }
        public Studio Studio { get => studio; set => studio = value; }
        #endregion
    }
}
