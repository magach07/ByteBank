﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos {
    internal class AutenticacaoHelper {
        public bool Helper(string senhaSalva, string tentativaSenha) {
            return senhaSalva == tentativaSenha;
        }
    }
}
