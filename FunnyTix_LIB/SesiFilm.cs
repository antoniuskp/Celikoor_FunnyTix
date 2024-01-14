using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace FunnyTix_LIB
{
    public class SesiFilm
    {
        #region DATA MEMBER
        private JadwalFilm jadwalFilm;
        private FilmStudio filmStudio;
        #endregion

        #region PROPERTIES
        public JadwalFilm JadwalFilm { get => jadwalFilm; set => jadwalFilm = value; }
        public FilmStudio FilmStudio { get => filmStudio; set => filmStudio = value; }

        #endregion

        #region CONSTRUCTOR
        public SesiFilm(JadwalFilm jadwalFilm, FilmStudio filmStudio)
        {
            this.jadwalFilm = jadwalFilm;
            this.filmStudio = filmStudio;
        }
        public SesiFilm()
        {
            this.JadwalFilm = new JadwalFilm();
            this.FilmStudio = new FilmStudio();
        }
        #endregion

        
    }
}
