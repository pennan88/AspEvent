using Microsoft.EntityFrameworkCore.Migrations;

namespace ASPuppgiftETT.Data.Migrations
{
    public partial class NewMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AttendeeEvent_Attendee_AttendeesAttendeeId",
                table: "AttendeeEvent");

            migrationBuilder.DropForeignKey(
                name: "FK_AttendeeEvent_Event_EventsEventId",
                table: "AttendeeEvent");

            migrationBuilder.RenameColumn(
                name: "EventId",
                table: "Event",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "EventsEventId",
                table: "AttendeeEvent",
                newName: "EventsId");

            migrationBuilder.RenameColumn(
                name: "AttendeesAttendeeId",
                table: "AttendeeEvent",
                newName: "AttendeesId");

            migrationBuilder.RenameIndex(
                name: "IX_AttendeeEvent_EventsEventId",
                table: "AttendeeEvent",
                newName: "IX_AttendeeEvent_EventsId");

            migrationBuilder.RenameColumn(
                name: "AttendeeId",
                table: "Attendee",
                newName: "Id");

            migrationBuilder.AlterColumn<int>(
                name: "OrganizerId",
                table: "Event",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateTable(
                name: "Organizer",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone_number = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Organizer", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Event_OrganizerId",
                table: "Event",
                column: "OrganizerId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Event_Organizer_OrganizerId",
                table: "Event",
                column: "OrganizerId",
                principalTable: "Organizer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AttendeeEvent_Attendee_AttendeesId",
                table: "AttendeeEvent");

            migrationBuilder.DropForeignKey(
                name: "FK_AttendeeEvent_Event_EventsId",
                table: "AttendeeEvent");

            migrationBuilder.DropForeignKey(
                name: "FK_Event_Organizer_OrganizerId",
                table: "Event");

            migrationBuilder.DropTable(
                name: "Organizer");

            migrationBuilder.DropIndex(
                name: "IX_Event_OrganizerId",
                table: "Event");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Event",
                newName: "EventId");

            migrationBuilder.RenameColumn(
                name: "EventsId",
                table: "AttendeeEvent",
                newName: "EventsEventId");

            migrationBuilder.RenameColumn(
                name: "AttendeesId",
                table: "AttendeeEvent",
                newName: "AttendeesAttendeeId");

            migrationBuilder.RenameIndex(
                name: "IX_AttendeeEvent_EventsId",
                table: "AttendeeEvent",
                newName: "IX_AttendeeEvent_EventsEventId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Attendee",
                newName: "AttendeeId");

            migrationBuilder.AlterColumn<int>(
                name: "OrganizerId",
                table: "Event",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_AttendeeEvent_Attendee_AttendeesAttendeeId",
                table: "AttendeeEvent",
                column: "AttendeesAttendeeId",
                principalTable: "Attendee",
                principalColumn: "AttendeeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AttendeeEvent_Event_EventsEventId",
                table: "AttendeeEvent",
                column: "EventsEventId",
                principalTable: "Event",
                principalColumn: "EventId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
