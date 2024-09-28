import {
  createRouter,
  createWebHistory,
  type RouteComponent,
  type RouteRecordRaw
} from 'vue-router'
import Home from '@/views/Home.vue'
import CreateProject from '@/views/CreateProject.vue'
import Blog from '@/views/Blog.vue'
import Project from '@/views/Project.vue'
import MyProfile from '@/views/MyProfile.vue'
import Organisations from '@/views/Organisations.vue'
import Login from '@/views/Login.vue'

const router = createRouter({
  history: createWebHistory(import.meta.env.BASE_URL),
  routes: [
    createRoute('/', 'home', Home, false),
    createRoute('/create-project', 'createProject', CreateProject, false),
    createRoute('/organisations', 'organisations', Organisations, false),
    createRoute('/my-profile', 'my-profile', MyProfile, false),
    createRoute('/blog', 'blog', Blog, false),
    createRoute('/project/:id', 'project', Project, false),
    createRoute('/login', 'login', Login, false)
  ]
})

function createRoute(
  path: string,
  name: string,
  component: RouteComponent | (() => Promise<any>),
  requiresAuth: boolean = true,
  children: RouteRecordRaw[] = []
): RouteRecordRaw {
  return {
    path,
    name,
    component,
    children,
    meta: {
      requiresAuth
    }
  }
}

export default router
