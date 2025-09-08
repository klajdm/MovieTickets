# Contributing to MovieTickets

Thank you for considering contributing to MovieTickets! We welcome contributions from everyone and are grateful for every contribution, no matter how small.

## 📋 Table of Contents

- [Code of Conduct](#code-of-conduct)
- [Getting Started](#getting-started)
- [How to Contribute](#how-to-contribute)
- [Development Setup](#development-setup)
- [Pull Request Process](#pull-request-process)
- [Style Guidelines](#style-guidelines)
- [Reporting Bugs](#reporting-bugs)
- [Suggesting Features](#suggesting-features)

## 📜 Code of Conduct

This project and everyone participating in it is governed by our Code of Conduct. By participating, you are expected to uphold this code. Please report unacceptable behavior to the project maintainers.

### Our Standards

- **Be respectful**: Treat everyone with respect and kindness
- **Be inclusive**: Welcome newcomers and encourage diverse perspectives
- **Be constructive**: Focus on what is best for the community
- **Be patient**: Understand that people have different skill levels and backgrounds

## 🚀 Getting Started

1. **Fork the repository** on GitHub
2. **Clone your fork** locally:
   ```bash
   git clone https://github.com/your-username/MovieTickets.git
   cd MovieTickets
   ```
3. **Set up the upstream remote**:
   ```bash
   git remote add upstream https://github.com/klajdm/MovieTickets.git
   ```

## 🤝 How to Contribute

### Types of Contributions

- **Bug fixes**: Help us fix issues in the codebase
- **Features**: Add new functionality to the application
- **Documentation**: Improve or add to our documentation
- **Tests**: Add or improve test coverage
- **Performance**: Optimize existing code for better performance
- **UI/UX**: Enhance the user interface and experience

## 💻 Development Setup

### Prerequisites

- .NET 8.0 SDK
- SQL Server (LocalDB, Express, or Full)
- Visual Studio 2022 or VS Code
- Git

### Local Development

1. **Install dependencies**:

   ```bash
   cd MovieTickets
   dotnet restore
   ```

2. **Set up the database**:

   ```bash
   dotnet ef database update
   ```

3. **Run the application**:

   ```bash
   dotnet run
   ```

4. **Run tests** (if available):
   ```bash
   dotnet test
   ```

## 📝 Pull Request Process

1. **Create a feature branch**:

   ```bash
   git checkout -b feature/your-feature-name
   ```

2. **Make your changes**:

   - Follow our coding standards
   - Add tests for new functionality
   - Update documentation as needed

3. **Test your changes**:

   ```bash
   dotnet build
   dotnet test
   ```

4. **Commit your changes**:

   ```bash
   git add .
   git commit -m "Add: brief description of your changes"
   ```

5. **Push to your fork**:

   ```bash
   git push origin feature/your-feature-name
   ```

6. **Create a Pull Request**:
   - Go to the GitHub repository
   - Click "New Pull Request"
   - Fill in the template with details about your changes

### Pull Request Guidelines

- **Title**: Use a clear, descriptive title
- **Description**: Explain what your changes do and why
- **Testing**: Describe how you tested your changes
- **Screenshots**: Include screenshots for UI changes
- **Breaking Changes**: Note any breaking changes

## 🎨 Style Guidelines

### C# Code Style

- Follow [Microsoft's C# Coding Conventions](https://docs.microsoft.com/en-us/dotnet/csharp/fundamentals/coding-style/coding-conventions)
- Use PascalCase for public members
- Use camelCase for private fields and local variables
- Use meaningful variable and method names
- Add XML documentation for public APIs

### Example:

```csharp
/// <summary>
/// Represents a movie in the cinema system
/// </summary>
public class Movie : IEntityBase
{
    /// <summary>
    /// Gets or sets the unique identifier for the movie
    /// </summary>
    public int Id { get; set; }

    private readonly string _name;

    /// <summary>
    /// Creates a new movie instance
    /// </summary>
    /// <param name="name">The name of the movie</param>
    public Movie(string name)
    {
        _name = name ?? throw new ArgumentNullException(nameof(name));
    }
}
```

### Database Migrations

- Always create migrations for database changes
- Use descriptive migration names
- Test migrations in both directions (up and down)

### Frontend Guidelines

- Follow responsive design principles
- Use Bootstrap classes consistently
- Ensure accessibility standards are met
- Test on multiple browsers and devices

## 🐛 Reporting Bugs

Before creating a bug report, please check the existing issues to avoid duplicates.

### Bug Report Template

When filing a bug report, include:

1. **Summary**: Brief description of the issue
2. **Steps to Reproduce**: Detailed steps to reproduce the bug
3. **Expected Behavior**: What you expected to happen
4. **Actual Behavior**: What actually happened
5. **Environment**:
   - OS and version
   - .NET version
   - Browser (if applicable)
6. **Screenshots**: If applicable
7. **Additional Context**: Any other relevant information

## 💡 Suggesting Features

We welcome feature suggestions! Please check existing issues and discussions first.

### Feature Request Template

1. **Summary**: Brief description of the feature
2. **Problem**: What problem does this solve?
3. **Solution**: Describe your proposed solution
4. **Alternatives**: Alternative solutions you've considered
5. **Benefits**: How will this benefit users?
6. **Additional Context**: Mockups, examples, etc.

## 🔍 Code Review Process

All submissions require review before merging:

1. **Automated Checks**: CI/CD pipeline runs automatically
2. **Peer Review**: At least one maintainer reviews the code
3. **Testing**: Changes are tested thoroughly
4. **Documentation**: Documentation is updated if needed

### Review Criteria

- Code quality and maintainability
- Test coverage
- Performance impact
- Security considerations
- User experience
- Documentation completeness

## 🏷️ Issue Labels

We use labels to categorize issues:

- `bug`: Something isn't working
- `enhancement`: New feature or request
- `documentation`: Documentation improvements
- `good first issue`: Good for newcomers
- `help wanted`: Extra attention needed
- `question`: Further information requested
- `wontfix`: This will not be worked on

## 🚀 Release Process

1. **Feature Freeze**: No new features for the release
2. **Testing**: Comprehensive testing of all features
3. **Documentation**: Update all relevant documentation
4. **Release Notes**: Prepare detailed release notes
5. **Tag**: Create a git tag for the release
6. **Deploy**: Deploy to production environment

## 📞 Getting Help

If you need help:

1. **Check the documentation**: README and wiki
2. **Search existing issues**: Someone may have asked the same question
3. **Ask in discussions**: Use GitHub Discussions for questions
4. **Contact maintainers**: Reach out to project maintainers

## 🎉 Recognition

Contributors are recognized in:

- Release notes
- Contributors section in README
- GitHub contributors graph
- Special thanks in significant releases

---

Thank you for contributing to MovieTickets! Your efforts help make this project better for everyone. 🎬✨
