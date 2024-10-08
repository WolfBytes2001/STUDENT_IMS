﻿Public Module randomWords
    Dim programmingWords() As String = {
    "algorithm",
    "argument",
    "arrays",
    "arithmetic operators",
    "assignment operators",
    "variable",
    "function",
    "loop",
    "conditional statement",
    "debugging",
    "syntax",
    "compiler",
    "interpreter",
    "recursion",
    "data structure",
    "object-oriented",
    "inheritance",
    "polymorphism",
    "encapsulation",
    "abstraction",
    "API",
    "GUI",
    "IDE",
    "version control",
    "database",
    "web development",
    "frontend",
    "backend",
    "API endpoint",
    "RESTful",
    "JSON",
    "XML",
    "HTTP",
    "HTTPS",
    "SSL",
    "framework",
    "library",
    "dependency",
    "bug",
    "refactoring",
    "unit testing",
    "integration testing",
    "agile",
    "SCRUM",
    "DevOps",
    "continuous integration",
    "deployment",
    "code review",
    "documentation",
    "comment",
    "git",
    "GitHub",
    "Bitbucket",
    "JIRA",
    "SQL",
    "NoSQL",
    "lambda expression",
    "stack",
    "queue",
    "heap",
    "binary search",
    "sorting algorithm",
    "hashing",
    "big O notation",
    "machine learning",
    "artificial intelligence",
    "cybersecurity",
    "API token",
    "sandbox environment",
    "serverless",
    "microservices",
    "containerization",
    "cloud computing",
    "scalability",
    "performance optimization",
    "code quality",
    "code smell",
    "agile manifesto",
    "design patterns",
    "singleton",
    "factory pattern",
    "MVC",
    "MVVM",
    "REST API",
    "GraphQL",
    "CI/CD pipeline",
    "dependency injection",
    "static analysis",
    "test-driven development",
    "continuous delivery",
    "code coverage",
    "pair programming",
    "agile sprint",
    "user story",
    "burn-down chart",
    "Kanban",
    "sprint retrospective",
    "merge conflict",
    "codebase",
    "legacy code",
    "code refactoring",
    "code smell",
    "code review",
    "code documentation"
}

    Public Function GenerateRandomPassword() As String
        ' Define a list of random words (you can customize this list)
        Dim randomWords() As String = programmingWords

        ' Generate two random indices to select words
        Dim random As New Random()
        Dim index1 As Integer = random.Next(0, randomWords.Length)
        Dim index2 As Integer = random.Next(0, randomWords.Length)

        ' Combine the two words with a random number
        Dim password As String = $"{randomWords(index1)}_{randomWords(index2)}_{random.Next(100, 1000)}"

        Return password
    End Function

End Module
