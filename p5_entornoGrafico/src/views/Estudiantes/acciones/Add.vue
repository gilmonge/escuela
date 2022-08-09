<template>
  <Navbar :regresar="true" />
  <div class="row pt-5 m-0">
    <div class="col-3"></div>
    <div class="col-6 row">
      <div class="col-9">
        <h3>Agregar</h3>
      </div>

      <form class="row g-3">
        <div class="form-group">
          <label for="nombre" class="visually-hidden">Nombre</label>
          <input
            type="text"
            class="form-control"
            id="nombre"
            placeholder="Nombre"
            v-model="estudiante.nombre"
          />
        </div>
        <div class="form-group">
          <label for="primer_apellido" class="visually-hidden"
            >Primer apellido</label
          >
          <input
            type="text"
            class="form-control"
            id="primer_apellido"
            placeholder="Primer apellido"
            v-model="estudiante.primer_apellido"
          />
        </div>
        <div class="form-group">
          <label for="segundo_apellido" class="visually-hidden"
            >Segundo apellido</label
          >
          <input
            type="text"
            class="form-control"
            id="segundo_apellido"
            placeholder="Segundo apellido"
            v-model="estudiante.segundo_apellido"
          />
        </div>
        <div class="form-group">
          <label for="edad" class="visually-hidden">Edad</label>
          <input
            type="number"
            class="form-control"
            id="edad"
            placeholder="Edad"
            v-model="estudiante.edad"
          />
        </div>

        <div class="form-group text-end">
          <button type="submit" class="btn btn-success mb-3" @click.prevent="guardarEstudiante">
            Registrar estudiante
          </button>
        </div>
      </form>
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
  name: "EstudiantesAdd",

  data() {
    return {
      estudiante: {
        nombre: "",
        primer_apellido: "",
        segundo_apellido: "",
        edad: null,
      },
    };
  },

  methods: {
    guardarEstudiante(){
      this.crearEstudiante(this.estudiante)

      this.$swal.fire({
        position: 'top-end',
        icon: 'success',
        title: 'Se ha agregado exitosamente',
        showConfirmButton: false,
        timer: 1500
      })

      let router = this.$router
      setTimeout(() => {
        router.push('/');
      }, 1500)
    },

    ...mapActions(["crearEstudiante"]),
  },

  components: {
    Navbar,
    FooterTemplate,
  },
};
</script>

<style>
</style>