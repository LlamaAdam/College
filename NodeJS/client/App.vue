<template>
    <div><router-view/></div>
</template>

<style scoped></style>

<script>
export default {
    name: 'App',
    computed: {
        user() { return this.$store.getters.user }
    },
    created() {
        if (!this.user && this.$route.name !== 'login')
            this.$router.push('/login')
    }
}
</script>