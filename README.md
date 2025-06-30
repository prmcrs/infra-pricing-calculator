# Calculadora de Costos de Infraestructura

Herramienta interna para estimar los costos mensuales o anuales asociados a la contratación de recursos tecnológicos dentro de la empresa.

Inspirada en la calculadora de Azure, pero adaptada a los servicios y precios utilizados internamente. Permite simular configuraciones y obtener presupuestos detallados sin necesidad de asistencia técnica.

## 🚀 Funcionalidades

- Estimación de costos de:
  - Máquinas virtuales (vCPU, RAM, disco, SO)
  - Almacenamiento (HDD / SSD)
  - Bases de datos (SQL Server, PostgreSQL, etc.)
  - Ancho de banda y servicios de red
  - Servicios adicionales (backups, soporte, monitoreo, etc.)
- Visualización del costo total mensual/anual
- Detalle por componente
- Exportación de simulaciones a PDF/Excel (próximamente)
- Interfaz simple y responsiva

## 🧱 Componentes Principales

- **Frontend:** Aplicación web con formularios dinámicos para configurar recursos
- **Backend:** Motor de cálculo basado en un catálogo de precios internos
- **Catálogo:** Archivo JSON o base de datos con precios por recurso

## 📦 Instalación

```bash
git clone https://github.com/tu-usuario/infra-cost-calculator.git
cd infra-cost-calculator
# Dependiendo del stack, seguir pasos de instalación
```

> ⚠️ Este proyecto es de uso interno. No está pensado para entornos productivos ni externos a la organización.

## 📊 Ejemplo de uso

1. Seleccioná el tipo de recurso que querés simular (ej: VM, Base de Datos).
2. Completá los parámetros deseados (CPU, RAM, tamaño de disco, etc.).
3. Visualizá el costo total estimado.
4. Exportá o compartí la simulación con tu equipo.

## 🛠️ Tecnologías sugeridas

- .NET Core / .NET 8
- Razor Pages o React + API REST
- JSON como fuente de precios o SQL Server para administración centralizada

## 📄 Licencia

Proyecto interno. Uso restringido dentro de la empresa.
