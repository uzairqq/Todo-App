﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoApp.Dtos;

namespace ToDoApp.DbServices.Interfaces
{
    public interface ITodoServices
    {
        Task<ResponseMessageDto> Save(TodoDto dto);
        Task<ResponseMessageDto> Update(TodoDto dto);
        Task<IEnumerable<TodoDto>> Get();

        Task<TodoDto> GetById(int id);
        Task<ResponseMessageDto> Delete(int id);



    }
}
