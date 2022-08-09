<template>
    <nav class="navbar navbar-light bg-light">
        <div class="container-fluid">
            <a class="navbar-brand">Prueba técnica - Escuela</a>

            <router-link to="/" v-if="regresar" class="btn btn-outline-info" type="submit" >Volver</router-link>
        </div>
    </nav>
</template>

<script>
export default {
    name: "NavbarTemplate",
    props: { 
        regresar: Boolean
    }
}
</script>

<style>

</style>