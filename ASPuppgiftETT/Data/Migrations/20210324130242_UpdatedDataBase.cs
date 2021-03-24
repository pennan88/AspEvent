using Microsoft.EntityFrameworkCore.Migrations;

namespace ASPuppgiftETT.Data.Migrations
{
    public partial class UpdatedDataBase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AttendeeEvent_Attendee_AttendeesId",
                table: "AttendeeEvent");

            migrationBuilder.DropForeignKey(
                name: "FK_AttendeeEvent_Event_EventsId",
                table: "AttendeeEvent");

            migrationBuilder.RenameColumn(
                name: "EventsId",
                table: "AttendeeEvent",
                newName: "EventId");

            migrationBuilder.RenameColumn(
                name: "AttendeesId",
                table: "AttendeeEvent",
                newName: "AttendeeId");

            migrationBuilder.RenameIndex(
                name: "IX_AttendeeEvent_EventsId",
                table: "AttendeeEvent",
                newName: "IX_AttendeeEvent_EventId");

            migrationBuilder.AddForeignKey(
                name: "FK_AttendeeEvent_Attendee_AttendeeId",
                table: "AttendeeEvent",
                column: "AttendeeId",
                principalTable: "Attendee",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AttendeeEvent_Event_EventId",
                table: "AttendeeEvent",
                column: "EventId",
                principalTable: "Event",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AttendeeEvent_Attendee_AttendeeId",
                table: "AttendeeEvent");

            migrationBuilder.DropForeignKey(
                name: "FK_AttendeeEvent_Event_EventId",
                table: "AttendeeEvent");

            migrationBuilder.RenameColumn(
                name: "EventId",
                table: "AttendeeEvent",
                newName: "EventsId");

            migrationBuilder.RenameColumn(
                name: "AttendeeId",
                table: "AttendeeEvent",
                newName: "AttendeesId");

            migrationBuilder.RenameIndex(
                name: "IX_AttendeeEvent_EventId",
                table: "AttendeeEvent",
                newName: "IX_AttendeeEvent_EventsId");

            migrationBuilder.AddForeignKey(
                name: "FK_AttendeeEvent_Attendee_AttendeesId",
                table: "AttendeeEvent",
                column: "AttendeesId",
                principalTable: "Attendee",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AttendeeEvent_Event_EventsId",
                table: "AttendeeEvent",
                column: "EventsId",
                principalTable: "Event",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
