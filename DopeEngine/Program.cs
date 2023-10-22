using DopeEngine.ECS;
using ImGuiNET;
using Raylib_cs;
using rlImGui_cs;

class Program
{
    static void Main(string[] args)
    {

        for (int i =0; i < 100; i++)
        {
            Entity rootEntity = EntityManager.GetSingleton().NewEntity();
            Console.WriteLine($"ID : {rootEntity.ID} , Index : {EntityManager.GetSingleton()._entities.ElementAt<Entity>(rootEntity.ID).ID}");
        }

        Raylib.InitWindow(800, 600, "Raylib imgui");
        Raylib.SetTargetFPS(60);

        rlImGui.Setup(true);

        while (!Raylib.WindowShouldClose())
        {
            Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.DARKGRAY);

            rlImGui.Begin();

            if (ImGui.Begin("test"))
            {

            }
            ImGui.End();
            rlImGui.End();

            Raylib.EndDrawing();
        }

        rlImGui.Shutdown();
        Raylib.CloseWindow();
    }
}