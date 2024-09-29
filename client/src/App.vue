<script setup lang="ts">
import { RouterView } from 'vue-router'
import UserMenu from './views/UserMenu.vue'
</script>

<template>
  <v-app>
    <v-app-bar fixed app class="elevation-0">
      <v-btn class="menuBtn" to="/" variant="text"> <img src="@/assets/Logo.png" width="100"></img> </v-btn>
      <v-btn class="menuBtn" to="/" variant="text" color="primary">  <span class="txt">{{ $t('menu.things') }} </span></v-btn>
      <v-btn class="menuBtn" to="/organizacje" variant="text" color="primary">
        <span class="txt">{{ $t('menu.organisations') }}</span>
      </v-btn>
      <v-btn class="menuBtn" to="/blog" variant="text" color="primary"> <span class="txt">{{ $t('menu.blog') }}</span> </v-btn>
      <v-spacer></v-spacer>
      <v-btn class="mr-3 specialBtn" to="/nowy-projekt" variant="text" color="primary">
        <span class="txt"> {{ $t('menu.create_project_or_grant') }}</span></v-btn
      >
      <user-menu></user-menu>
    </v-app-bar>
    <section class="main">
      <RouterView />
    </section>
  </v-app>
</template>

<style scoped>
.main {
  margin-top: 74px;
  padding: 0 20px;
}

@font-face {
  font-family: "Raleway Thin";
  src: url('./assets/fonts/Raleway-Thin.ttf');
  font-weight: 300;
  font-style: normal;
}

@font-face {
  font-family: "Raleway Regular";
  src: url('./assets/fonts/Raleway-Regular.ttf');
  font-weight: 500;
  font-style: normal;
}

@font-face {
  font-family: "Raleway Bold";
  src: url('./assets/fonts/Raleway-Bold.ttf');
  font-weight: 700;
  font-style: normal;
}

.v-toolbar__content{
  a{
    font-family: 'Raleway Black';
  }
}

.v-btn--active{
  .txt{
    font-family: 'Raleway Bold';
    border-bottom: 2px solid #f88917;
  }
}

.menuBtn :deep(.v-btn__overlay) {
  opacity: 0;
}

.specialBtn{
  background-color: #fdc874;
  
  .txt{
    color: black;
    border-bottom: none;
  }
}

.main {
  margin-top: 80px;
}

</style>
