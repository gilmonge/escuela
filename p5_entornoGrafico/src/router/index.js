import { createWebHistory, createRouter } from "vue-router";

import Login from "@/views/Estudiantes/route";

let routes = [];
routes = routes.concat(
    Login,
)

const router = createRouter({
  history: createWebHistory(process.env.BASE_URL),
  routes
})

export default router
