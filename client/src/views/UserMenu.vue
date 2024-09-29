<script setup lang="ts">
import router from '@/router'
import { getUser, logout, userChangedEvent } from '@/store/auth'
import { ref, watch, onMounted, onUnmounted } from 'vue'

const user = ref<string>(getUser())

function onLogout() {
  logout()
  router.push('/')
}

function updateUser() {
  user.value = getUser()
}

onMounted(() => {
  window.addEventListener(userChangedEvent, updateUser)
})

onUnmounted(() => {
  window.removeEventListener(userChangedEvent, updateUser)
})
</script>

<template>
  <v-btn v-if="user === ''" to="/login"> Zaloguj </v-btn>
  <v-container v-if="user !== ''" width="auto">
    <v-row>
      <v-menu min-width="200px" rounded>
        <template v-slot:activator="{ props }">
          <v-btn icon v-bind="props">
            <v-avatar color="brown" size="large">
              <span>F</span>
            </v-avatar>
          </v-btn>
        </template>
        <v-card>
          <v-card-text>
            <div>
              <v-avatar color="brown">
                <span class="text-h5">F</span>
              </v-avatar>
              <h3>{{ user }}</h3>
              <p class="text-caption mt-1">{{ user }}@gmail.com</p>
              <v-divider class="my-3"></v-divider>
              <v-btn variant="text" rounded to="/my-profile"> Mój profil </v-btn>
              <v-divider class="my-3"></v-divider>
              <v-btn variant="text" rounded :onclick="onLogout"> Wyloguj </v-btn>
            </div>
          </v-card-text>
        </v-card>
      </v-menu>
    </v-row>
  </v-container>
</template>
