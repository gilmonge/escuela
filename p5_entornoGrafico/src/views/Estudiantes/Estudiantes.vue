<template>
  <Navbar />
  <div class="row pt-5 m-0">
    <div class="col-3"></div>
    <div class="col-6 row">
      <div class="col-9">
        <h3>Listado de estudiantes</h3>
      </div>
      <div class="col-3">
        <router-link to="/add" type="button" class="btn btn-success mx-1"
          >Agregar</router-link
        >
      </div>

      <table class="table table-striped">
        <thead>
          <tr>
            <th class="text-center" scope="col">#</th>
            <th class="text-center" scope="col">Nombre completo</th>
            <th class="text-center" scope="col">Edad</th>
            <th class="text-center" scope="col"></th>
          </tr>
        </thead>
        <tbody>
          <tr
            v-for="estudiante in estudiantes"
            v-bind:key="estudiante.estudiante_id"
          >
            <th class="text-center" scope="row">
              {{ estudiante.estudiante_id }}
            </th>
            <td class="text-center">
              {{ estudiante.nombre }} {{ estudiante.primer_apellido }}
              {{ estudiante.segundo_apellido }}
            </td>
            <td class="text-center">{{ estudiante.edad }}</td>
            <td class="text-center">
              <router-link
                :to="'/edit/' + estudiante.estudiante_id"
                type="button"
                class="btn btn-primary mx-1"
                >Editar</router-link
              >

              <router-link
                :to="'/delete/' + estudiante.estudiante_id"
                type="button"
                class="btn btn-danger mx-1"
                >Borrar</router-link
              >
            </td>
          </tr>
        </tbody>
      </table>
    </div>
    <div class="col-3"></div>
  </div>
  <FooterTemplate />
</template>

<script>
import Navbar from "@/template/Navbar.vue";
import FooterTemplate from "@/template/Footer.vue";
import { mapActions } from "vuex";
export default {
  name: "EstudiantesView",

  data() {
    return {
      estudiantes: [],
    };
  },

  methods: {
    async traerEtudiantes() {
      this.estudiantes = await this.obtenerEstudiantes();
    },

    ...mapActions(["obtenerEstudiantes"]),
  },

  components: {
    Navbar,
    FooterTemplate,
  },

  async mounted() {
    await this.traerEtudiantes();
  },
};
</script>

<style>
</style>