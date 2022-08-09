import Estudiantes from "./Estudiantes.vue";
import EstudiantesAdd from "./acciones/Add.vue";
import EstudiantesEdit from "./acciones/Edit.vue";
import EstudiantesDelete from "./acciones/Delete.vue";

const route = [
    {
        path: "/",
        name: "Estudiantes",
        component: Estudiantes,
    },
    {
        path: "/add",
        name: "EstudiantesAdd",
        component: EstudiantesAdd,
    },
    {
        path: "/edit/:id",
        name: "EstudiantesEdit",
        component: EstudiantesEdit,
    },
    {
        path: "/delete/:id",
        name: "EstudiantesDelete",
        component: EstudiantesDelete,
    },
];

export default route;