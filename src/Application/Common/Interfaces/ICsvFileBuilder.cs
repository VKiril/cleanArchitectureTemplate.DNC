﻿using tmp.Application.TodoLists.Queries.ExportTodos;
using System.Collections.Generic;

namespace tmp.Application.Common.Interfaces
{
    public interface ICsvFileBuilder
    {
        byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records);
    }
}
