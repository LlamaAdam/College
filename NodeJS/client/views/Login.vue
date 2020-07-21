<template>
    <section>
        <div style="width: 100%; text-align: center;">
            <h5>Your App has compiled successfully.  Proceed to implement the XD file specification.</h5>
            <form @submit.prevent="loginUser">
                <div><label>Username</label><input v-model="username"/></div>
                <div><label>Password</label><input type="password" v-model="password"/></div>
                <div v-if="error_message">{{error_message}}</div>
                <button type="submit">Submit</button>
            </form>
        </div>
    </section>
</template>

<style scoped>

</style>

<script>
export default {
    name: 'Login',
    data() {
        return {
            username: undefined,
            password: undefined,
            error_message: undefined,
        }
    },
    methods: {
        loginUser() {
            console.log(this.username, this.password)
            this.$store.dispatch('loginUser', {
                username: this.username, password: this.password,
                success: () => {
                    this.$router.push('/')
                },
                error: (result) => {
                    this.error_message = 'Invalid Username or Password'
                }
            })
        }
    }
}
</script>