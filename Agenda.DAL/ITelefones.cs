﻿using Agenda.Domain;
using System;
using System.Collections.Generic;

namespace Agenda.DAL
{
    public interface ITelefones
    {
        List<ITelefone> ObterTodosDoContatos(Guid ContatoId);
    }
}
