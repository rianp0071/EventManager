# EventManager
Steps to run the project

1. Create a new folder for your project

2. In that folder, create a new blazor wasm in VS or VS Code and name it EventManagerApp

3. Add the Data Folder and its contents to your project

4. Add the Services Folder and its contents to your project

5. Replace the Pages Folder with my Pages folder and its contents

6. Add the following lines to your Program.cs file :


builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<IEventService, EventService>();

