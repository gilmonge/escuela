<template>
  <Navbar :regresar="true" />

  <div class="row pt-5 m-0">
    <div class="col-3"></div>
    <div class="col-6 row">
      <div class="col-9">
        <h3>Eliminar de estudiantes</h3>
      </div>

      <div class="alert alert-danger" role="alert">
        Esta seguro(a) de eliminar a <a href="#" class="alert-link">{{estudiante.nombre}} {{estudiante.primer_apellido}} {{estudiante.segundo_apellido}}</a>
      </div>

      <div class="form-group text-end">
        <button type="submit" class="btn btn-danger mb-3" @click.prevent="eliminarEstudiante">
          Sí, quiero eliminar el estudiante
        </button>
      </div>
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
  name: "EstudiantesDelete",

  data() {
    return {
      id: this.$route.params.id,
      estudiante: []
    };
  },

  methods: {
    async traerEtudiante() {
      this.estudiante = await this.obtenerEstudiante(this.id);
    },

    async eliminarEstudiante(){
      await this.borrarEstudiante(this.id)

      this.$swal.fire({
        position: 'top-end',
        icon: 'success',
        title: 'Se ha eliminado exitosamente',
        showConfirmButton: false,
        timer: 1500
      })

      let router = this.$router
      setTimeout(() => {
        router.push('/');
      }, 1500)
    },

    ...mapActions(["obtenerEstudiante", "borrarEstudiante"]),
  },

  components: {
    Navbar,
    FooterTemplate,
  },

  async mounted() {
    await this.traerEtudiante();
  },
};
</script>

<style>
</style>