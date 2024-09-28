import { createRouter, createWebHistory, type RouteComponent, type RouteRecordRaw } from 'vue-router';
import Home from '@/views/Home.vue'
import About from '@/views/About.vue'
import CreateProject from '@/views/CreateProject.vue'
import News from '@/views/News.vue'
import Project from '@/views/Project.vue'

export function createAppRouter() {
  const router = createRouter({
    history: createWebHistory(import.meta.env.BASE_URL),
    routes: [
      createRoute('/', 'home', Home, false),
      createRoute('/create-project', 'createProject', CreateProject, false),
      createRoute('/about', 'about', About, false),
      createRoute('/news', 'news', News, false),
      createRoute('/project/:id', 'project', Project, false)
    ],
  });
  
  return router
}

function createRoute(
  path: string,
  name: string,
  component: RouteComponent | (() => Promise<any>),
  requiresAuth: boolean = true,
  children: RouteRecordRaw[] = [],
): RouteRecordRaw {
  return {
    path,
    name,
    component,
    children,
    meta: {
      requiresAuth,
    },
  };
}
