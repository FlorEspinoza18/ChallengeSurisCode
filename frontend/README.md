📌 Gestión de Reservas - Desafío
Este proyecto consiste en desarrollar una aplicación web para gestionar reservas de un servicio.

🎯 Objetivo
Permitir a los usuarios seleccionar un servicio, elegir una fecha y un horario disponible, y asociar la reserva a un cliente.

🖥️ Tecnologías Utilizadas
Frontend: React
Backend: C# .NET (API)
Base de datos: JSON Server (para datos de prueba)

🚀 Instalación y Ejecución
1️⃣ Clonar el repositorio
git clone https://github.com/tu-repo.git

2️⃣ Instalar dependencias
npm install

3️⃣ Configurar y ejecutar JSON Server (datos de prueba)
npm install -g json-server
json-server --watch db.json --port 5000

4️⃣ Iniciar el frontend
npm run dev

📌 Funcionalidades Principales
✅ Seleccionar un servicio a reservar
✅ Elegir una fecha y horario disponible
✅ Ingresar el nombre del cliente
✅ Generar una reserva
✅ Ver el listado de reservas generadas

🔧 Requisitos Técnicos
Frontend
✔ Permitir la selección de servicios
✔ Validar que no falten datos al generar una reserva

Backend (API en C# .NET)
✔ Endpoint GET /servicios → Retorna el listado de servicios
✔ Endpoint GET /reservas → Retorna todas las reservas generadas
✔ Endpoint POST /reservas → Recibe una nueva reserva, valida los datos y confirma si fue exitosa
