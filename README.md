# EventManager
Steps to run the project

1. Create a new blazor wasm in VS or VS Code

2. Add the Data Folder and its contents to your project

3. Add the Services Folder and its contents to your project

4. Replace the Pages Folder with my Pages folder and its contents

5. Add the following lines to your Program.cs file :


builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<IEventService, EventService>();

