using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ToDoList.Migrations
{
    public partial class _002 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Interessados_Tarefa_TarefaId",
                table: "Interessados");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tarefa",
                table: "Tarefa");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tarefas",
                table: "Tarefa",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Interessados_Tarefas_TarefaId",
                table: "Interessados",
                column: "TarefaId",
                principalTable: "Tarefa",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.RenameTable(
                name: "Tarefa",
                newName: "Tarefas");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Interessados_Tarefas_TarefaId",
                table: "Interessados");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tarefas",
                table: "Tarefas");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tarefa",
                table: "Tarefas",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Interessados_Tarefa_TarefaId",
                table: "Interessados",
                column: "TarefaId",
                principalTable: "Tarefas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.RenameTable(
                name: "Tarefas",
                newName: "Tarefa");
        }
    }
}
