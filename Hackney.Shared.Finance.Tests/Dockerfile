FROM mcr.microsoft.com/dotnet/core/sdk:6.0

# disable microsoft telematry
ENV DOTNET_CLI_TELEMETRY_OPTOUT='true'

ARG LBHPACKAGESTOKEN
WORKDIR /app

# Copy everything else and build
COPY . .

RUN dotnet build -o out Hackney.Shared.Finance.Tests/Hackney.Shared.Finance.Tests.csproj

CMD dotnet test