# ServiciosAndresDuran2doCorte

**Autor:** JugloqWasHere  
**Descripción:** Proyecto educativo realizado en **Unity** que agrupa dos subproyectos relacionados con servicios de red y correo electrónico:

1. **DDoS Test (educativo / controlado)** — Un experimento para simular (en un entorno de pruebas controlado) comportamientos de carga/denegación de servicio con fines didácticos y de aprendizaje de redes. **IMPORTANTE:** no ejecutar contra sistemas de terceros sin autorización explícita. :contentReference[oaicite:0]{index=0} :contentReference[oaicite:1]{index=1}

2. **SMTP Email Interface** — Interfaz/cliente dentro de Unity para enviar correos mediante SMTP (útil para comprender cómo funcionan las conexiones SMTP, autenticación y envío desde aplicaciones Unity). :contentReference[oaicite:2]{index=2}

---

## Contenido del repositorio
- `Assets/` — Código y escenas de Unity (incluye subproyectos).
- `ProjectSettings/` — Ajustes del proyecto Unity.
- Archivos auxiliares (`.gitignore`, `.gitattributes`, etc.)

> (Si necesitas que enumere archivos y scripts específicos, lo puedo hacer; pero por ahora mantuve el README general — dime si quieres que lea y liste cada archivo del `Assets/`.)

---

## Advertencia legal y ética (LEE ESTO)
- **No realices pruebas contra servidores o servicios que no te pertenezcan o para los que no tengas permiso por escrito.** Realizar pruebas de denegación de servicio sin autorización es ilegal en muchos países y puede acarrear consecuencias serias. :contentReference[oaicite:3]{index=3}  
- Siempre documenta un **Alcance y Carta de Autorización** cuando hagas pruebas incluso en entornos de clientes o terceros. :contentReference[oaicite:4]{index=4}  
- Para pruebas seguras: **usa redes y servidores locales o entornos en la nube que explícitamente permitan pruebas (p. ej. zonas y recursos que controles)** y respeta las políticas del proveedor. :contentReference[oaicite:5]{index=5}

---

## Requisitos
- Unity (versión compatible con los assets del proyecto).
- Para la parte de SMTP: acceso a un servidor SMTP (puede ser un servidor de pruebas local o un servicio que controles). Nunca incluyas credenciales en el repositorio.  
- Permisos y entorno aislado (para la parte de test de carga).

---

## Cómo usar (resumen — instrucciones **seguras** y no operacionales)
> **Nota:** aquí no se dan pasos operativos para lanzar ataques DDoS contra terceros. Sólo instrucciones seguras para ejecutar el repositorio en un entorno controlado.

### 1. Abrir el proyecto en Unity
1. Clona el repositorio:
   ```bash
   git clone https://github.com/JugloqWasHere/ServiciosAndresDuran2doCorte.git
