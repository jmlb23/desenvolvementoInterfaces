﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
namespace post.Modelo.entidades
{
    public interface Entidade
    {
        BsonDocument ToDocument();
    }
}