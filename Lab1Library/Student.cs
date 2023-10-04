﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Library
{
    [Serializable]
    public class Student
    {
        /// <summary>
        /// Studenta vārds.
        /// </summary>
        /* Vizuālā programmēšana, G. Alksnis, 2015, r162 */ /* 12 */
        public string Name { get; set; }

        /// <summary>
        /// Studenta uzvārds.
        /// </summary>
        public string Surname { get; set; }

        /// <summary>
        /// Studenta apliecības numurs.
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// Konstruktors, kas nepieciešams atribūtam [Serializable]
        /// </summary>
        /// 
        public string Group { get; set; }
        /// <summary>
        /// Studenta grupas numurs.
        /// </summary>
        /// 
        public string Email { get; set; }
        /// <summary>
        /// Studenta epasts.
        /// </summary>
        /// 
        private Student() { }
        /// <summary>
        /// Konstruktors, kas inicializē klases īpašības.
        /// </summary>
        public Student(string name, string surname, string id, string group, string email)
        {
            //ja kāds no parametriem ir tukša virkne, izraisīt izņēmumu
            if (name.Length == 0 || surname.Length == 0 || id.Length == 0 || group.Length == 0 || email.Length == 0) throw new Exception("Invalid student data !");
            this.Name = name;
            this.Surname = surname;
            this.Id = id;
            this.Group = group;
            this.Email = email;
        }
        /// <summary>
        // Teksta virknes formā atgriež klases īpašību vērtības.
        /// </summary>
        public override string ToString()
        {
            return Id + " : " + Name + " " + Surname + " " + Group + " " + Email;
        }

    }
}
