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
import MyProfile from '@/views/MyProfile/MyProfile.vue'
import Organisations from '@/views/Organisations.vue'
import Login from '@/views/Login.vue'
import Ngo from '@/views/Ngo.vue'
import Company from '@/views/Company.vue'

const router = createRouter({
    history: createWebHistory(import.meta.env.BASE_URL),
    routes: [
        createRoute('/', 'home', Home, false),
        createRoute('/nowy-projekt', 'createProject', CreateProject, false),
        createRoute('/organizacje', 'organisations', Organisations, false),
        createRoute('/my-profile', 'my-profile', MyProfile, false),
        createRoute('/blog', 'blog', Blog, false),
        createRoute('/projekty/:slug', 'project', Project, false),
        createRoute('/login', 'login', Login, false),
        createRoute('/ngo/:slug', 'ngo', Ngo, false),
        createRoute('/company/:slug', 'company', Company, false)
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
