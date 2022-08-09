import { createStore } from 'vuex'

export default createStore({
    state: {
        apiEstudiantes: "http://localhost:5153"
    },
    getters: {
    },
    mutations: {
    },
    actions: {
        async obtenerEstudiantes() {
            let url = `${this.state.apiEstudiantes}/api/Estudiantes`
            let estudiantes = []
            estudiantes = await fetch(url).then(res => res.json()).catch(text => console.log(text))
            return estudiantes
        },

        // eslint-disable-next-line
        async obtenerEstudiante({ }, id) {
            let url = `${this.state.apiEstudiantes}/api/Estudiantes/${id}`
            let estudiantes = []
            estudiantes = await fetch(url).then(res => res.json()).catch(text => console.log(text))
            return estudiantes
        },
        
        // eslint-disable-next-line
        async crearEstudiante({ }, estudiante) {
            let url = `${this.state.apiEstudiantes}/api/Estudiantes`
            let config = { 
                method: 'POST',
                headers: {
                    'Content-type': 'application/json; charset=UTF-8'
                },
                body: JSON.stringify(estudiante)
            }
            await fetch(
                url,
                config
            ).then(res => res.json()).catch(text => console.log(text))
        },
        
        // eslint-disable-next-line
        async actualizarEstudiante({ }, data) {
            let url = `${this.state.apiEstudiantes}/api/Estudiantes/${data.id}`
            let config = { 
                method: 'PUT',
                headers: {
                    'Content-type': 'application/json; charset=UTF-8'
                },
                body: JSON.stringify(data.estudiante)
            }
            await fetch(
                url,
                config
            ).then(res => res.json()).catch(text => console.log(text))
        },
        
        // eslint-disable-next-line
        async borrarEstudiante({ }, id) {
            let url = `${this.state.apiEstudiantes}/api/Estudiantes/${id}`
            await fetch(
                url,
                { method: 'DELETE', }
            ).then(res => res.json()).catch(text => console.log(text))
        },
    },
    modules: {
    }
})
