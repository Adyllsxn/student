# Setup do Projeto STUDENT

## 🧰 Pré-requisitos

- [.NET SDK](https://dotnet.microsoft.com/) 8.0+
- [Node.js](https://nodejs.org/) 18+
- [Docker](https://www.docker.com/) (opcional, para ambiente completo)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)

---

## ⚙️ Backend (API)

cd src/backend
dotnet restore
dotnet build
dotnet run

---

## 🖥️ Frontend (React)
cd src/frontend/student.web
npm install
npm run dev


## 🧪 Rodando Testes
cd test/Student.UnitTest
dotnet test

---

## 🐳 Usando Docker (opcional)
docker-compose up --build

---
