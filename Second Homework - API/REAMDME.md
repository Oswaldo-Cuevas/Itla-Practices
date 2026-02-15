SoundJournal API

Descripción

**SoundJournal** es una API REST desarrollada para registrar y gestionar información relacionada con sonidos o registros musicales.
Permite crear, consultar, actualizar y eliminar registros mediante peticiones HTTP, facilitando la comunicación entre aplicaciones cliente y el servidor.
El proyecto fue desarrollado con fines académicos para practicar el desarrollo de APIs, arquitectura backend y manejo de datos.

## Funcionalidades

- Crear registros de sonidos
- Consultar registros existentes
- Actualizar información
- Eliminar registros
- Manejo de datos mediante endpoints REST

## Estructura del Proyecto

El proyecto está organizado en:

- Controllers → Manejan la lógica de las solicitudes.
- Models / Entities → Representan la estructura de los datos.
- Database / Context → Conexión y manejo de la base de datos.
- Endpoints → Rutas para interactuar con la API.

## Endpoints Principales

- `GET /api/sounds` → Obtener todos los registros  
- `GET /api/sounds/{id}` → Obtener registro por ID  
- `POST /api/sounds` → Crear nuevo registro  
- `PUT /api/sounds/{id}` → Actualizar registro  
- `DELETE /api/sounds/{id}` → Eliminar registro  

## Pruebas

La API puede probarse con herramientas como:

- Postman
- Thunder Client
- Swagger (si está configurado)

Oswaldo Cuevas Feliz
2024-2602
ITLA
---
