# **GUARDIANS OF THE GLOBE PROYECT**
![Guardians]( https://imagecomics.com/legacy_images/blog_images/335834916022825.jpg)

## **INTRODUCCION**
Aplicación web desarrollada utilizando diferentes tecnologías (Razor,Html,Css,Bootstrap,.net) para el frontend y MongoDB como base de datos para el backend. La aplicación tiene como objetivo principal gestionar la información de los superhéroes y villanos pertenecientes al universo "The Guardians of the Globe" y cumplir con los requisitos establecidos.

## **INSTALACION**
Para configurar el entorno de desarrollo, sigue estos pasos:

- Clona el repositorio desde [GitHub].
- Ejecuta la aplicacion

## **ESTRUCTURA DEL PROYECTO**
El proyecto está organizado en las siguientes carpetas y archivos principales:
- **Pages:** Contiene las páginas Razor correspondiente a la interfaz grafica (FrontEnd).
- **Services:** Implementan la lógica de negocio o la manipulación de datos en la aplicación. 
- **Models:** Contiene las clases de modelos para las entidades de la base de datos.
- **Entities:** Contiene los objetos principales de la aplicación, como datos que se almacenan y manipulan.

## **CONFIGURACION DB:**
- La base de datos esta alojada en el archivo "AppSettings.json"

## **MODELOS DE DATOS:**
- **Hero:** Representa a un superhéroe.
- **Villain:** Representa a un villano.
- **patterns** Representa un patrocinador
- **Fight:** Registra las peleas entre The Guardians y los villanos.
- **Diary:** Registra las actividades de los heroes.

### DIAGRAMA DE CLASES UML
![Guardians]( https://github.com/sebas000007/GuardiansOfTheGlobeProyect/blob/main/Images/ClassDiagram.png?raw=true)

## Scripts de creación y población de la base de datos
- Se utilizaron archivos JSON para poder enviar los datos a la DataBase en la nube de MongoDB ATLAS
- Los Xml estan alojados en la carpeta "JSON" del proyecto
![Json]( https://github.com/sebas000007/GuardiansOfTheGlobeProyect/blob/main/Images/JsonExample.PNG?raw=true)


## **Funcionalidades**
### *La aplicacion web tendra las siguientes funcionalidades:*

**1.** Conocer la información básica de los héroes (Nombre, edad, etc), habilidades, debilidades
  y principales relaciones personales.

**2.** Organizar y guardar información básica de los villanos (Nombre, edad, etc), habilidades,
  origen y poder.

**3.** Manejar la agenda de los superhéroes, tener en cuenta que algunos son adolescentes y
  deben asistir a la escuela para cumplir con sus labores y también sus reuniones familiares.

**4.** Organizar una lista de patrocinadores de cada héroe, el monto y lo más importante el
origen del dinero para revisar si se puede confiar.

**5.** Finalmente se quiere conocer las luchas que han tenido los integrantes The Guardians y
Mark, así como el resultado y contra que villano. 

**6.** Consultar con que villano ha peleado más veces un héroe seleccionado con la información
relacionada a las peleas.

**7.** Poder consultar los 3 héroes con mayor número de victorias.

**8.** Consultar listado de héroes por:
- Consultar héroes por nombre
- Consultar héroes por habilidades
- Consultar héroes por principales relaciones personales.

**9.** Consultar listado de villanos por:
- Consultar villano por nombre
- Consultar villano por origen.
- Consultar villano por debilidad.

**10.** Consultar información del patrocinador relacionado a un héroe con mayor monto.

**11.** Organizar y agrupar héroes por edad (Adolescentes-mayores de edad).

**12.** Consultar que villano ha perdido más contra un héroe adolescente.

## **PROTOTIPO UX/UI**
<img src="https://github.com/sebas000007/GuardiansOfTheGlobeProyect/blob/main/Images/ProtoType_UXUI.png?raw=true" alt="Prototype" height="300">




