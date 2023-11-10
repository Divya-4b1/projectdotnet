﻿using DoctorModelLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoctorDALLibrary;


namespace DoctorBLLLibrary
{
    
        public interface IDoctorService
        {
            public Doctor AddDoctor(Doctor doctor);
            public Doctor Delete(int id);
            public Doctor GetDoctor(int id);
            public List<Doctor> GetDoctor();
            public Doctor UpdateContactNumber(int id, long phnum);
            public Doctor UpdateExperience(int id, int docexp);
        }
    }

