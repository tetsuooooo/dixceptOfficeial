<template>

    <v-footer color="#1B5E20"
              padless
              class="mt-5">
        <v-row justify="center"
               no-gutters>
            <v-btn v-for="link in links"
                   :key="link"
                   color="white"
                   text
                   rounded
                   class="my-2">
                {{ link }}
            </v-btn>
            <v-col class="bg_color py-4 text-center white--text"
                   cols="12">
                <strong>dixsept Official</strong>
            </v-col>
        </v-row>
    </v-footer>
</template>

<script lang="ts">
    import { Component, Vue } from 'vue-property-decorator';

    @Component({
        components: {
        },
    })
    export default class Home extends Vue {
        data() {
            return {
                links: ["Home", "Team", "Player", "News", "MatchSchedule", "Contact"]
            }
        }
    }
</script>

<style scoped>
</style>
