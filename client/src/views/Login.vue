<script setup lang="ts">
import router from '@/router'
import { setUser, type UserType } from '@/store/auth'
import { ref } from 'vue'

// Form data
const login = ref<string>('')
const password = ref<string>('')
const valid = ref<boolean>(false)
const form = ref<any>(null)

const loginRules = [
  (v: string) => v === 'Firma' || v === 'Fundacja' || 'Login to Firma lub Fundacja'
]

const passwordRules = [(v: string) => !!v || 'Hasło wymagane']

// Handle form submission
const submitLogin = () => {
  if (form.value?.validate()) {
    setUser(login.value as UserType)
    router.push('/')
  }
}
</script>

<template>
  <v-container class="login-container">
    <v-card max-width="400">
      <v-card-title class="text-h5">Login</v-card-title>

      <v-card-text>
        <v-form ref="form" v-model="valid" @submit.prevent="submitLogin">
          <v-text-field v-model="login" label="Login" :rules="loginRules" required></v-text-field>

          <v-text-field
            v-model="password"
            label="Hasło"
            :rules="passwordRules"
            type="password"
            required
          ></v-text-field>

          <v-btn color="primary" :disabled="!valid" type="submit"> Zaloguj </v-btn>
        </v-form>
      </v-card-text>
    </v-card>
  </v-container>
</template>

<style scoped>
.login-container {
  text-align: -webkit-center;
}
</style>
