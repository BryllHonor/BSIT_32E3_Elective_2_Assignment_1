# BSIT_32E3_Elective_2_Assignment_1

A simple ASP.NET Core MVC application that displays the supplied Server-Side Rendering and Web API multiple-choice questions, highlights the correct answers, and provides short explanations.

## Requirements
- .NET 9 SDK
- Visual Studio 2022 with the ASP.NET and web development workload, or the .NET CLI

## Run the project
1. Open `BSIT_32E3_Elective_2_Assignment_1.csproj` in Visual Studio.
2. Set the project as the startup project.
3. Run using HTTPS or press F5.

Or use a terminal in this folder:

```bash
dotnet restore
dotnet run
```

Open the local URL shown in the terminal.

## Structure
- `Controllers/HomeController.cs` – sends the quiz questions to the view.
- `Models/QuizQuestion.cs` – question model.
- `Views/Home/Index.cshtml` – displays questions, options, answers, and explanations.
- `Views/Shared/_Layout.cshtml` – shared page layout.
- `wwwroot/css/site.css` – page styling.

Question 9 was truncated in the supplied prompt. The project uses `ActionResult<T>` as the likely correct answer and supplies illustrative choices to complete the display.
